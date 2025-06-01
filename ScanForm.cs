using Client_Library;
using keylogger_lib.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualKeyloggerDetector.Core;
using VisualKeyloggerDetector.Core.Injection;
using VisualKeyloggerDetector.Core.PatternGeneration;
using VisualKeyloggerDetector.Core.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KLDS
{
    public partial class ScanForm : Form
    {
        private DashboardForm _dashboardForm;
        private ExperimentController _experimentController;
        private ExperimentConfiguration _currentConfig = null; // Store config
        private KeyLogService keyLogService = new KeyLogService(); // Assuming you have a service to handle keylog data

        public ScanForm(DashboardForm dashboardForm)
        {
            InitializeComponent();
            _dashboardForm = dashboardForm;
            InitializeExperiment(); // Setup controller on startup
            Percentage.Text = "0%"; // Initialize percentage text
            Panel verticalMask = new Panel
            {
                Width = SystemInformation.VerticalScrollBarWidth,
                Height = Process_Scanned.Height,
                Left = Process_Scanned.Right - SystemInformation.VerticalScrollBarWidth,
                Top = Process_Scanned.Top,
                BackColor = Process_Scanned.BackgroundColor, // Or match DataGridView background
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom
            };
            this.Controls.Add(verticalMask);
            verticalMask.BringToFront();
        }

        private void InitializeExperiment()
        {
            string Setting_file_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_Configuration.json");

            String setting = File.ReadAllText(Setting_file_Path);
            ExperimentConfiguration _config = JsonSerializer.Deserialize<ExperimentConfiguration>(setting, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            _currentConfig = _config;
            if (_currentConfig.MinKeysPerIntervalKmin == 0 || _currentConfig.MaxKeysPerIntervalKmax == 0 || _currentConfig.IntervalDurationT == 0 || _currentConfig.PatternLengthN == 0)
            {
                MessageBox.Show("Please set the configuration parameters before starting the experiment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Detection_Form().Show();
            }

            IPatternGeneratorAlgorithm algorithm = null;
            switch (_currentConfig.index_algo)
            {
                case 0:
                    algorithm = new RandomFixedRangePatternAlgorithm();
                    break;
                case 1:
                    algorithm = new ImpulsePatternAlgorithm();
                    break;
                case 2:
                    algorithm = new SineWavePatternAlgorithm();
                    break;

            }
            // Dispose previous instance if any, before creating a new one
            _experimentController?.Dispose();
            _experimentController = new ExperimentController(_currentConfig, algorithm);

            // Subscribe to events from the controller to update the UI
            _experimentController.StatusUpdated += ExperimentController_StatusUpdated;
            _experimentController.ProgressUpdated += ExperimentController_ProgressUpdated;
            _experimentController.ExperimentCompleted += ExperimentController_ExperimentCompleted;
            _experimentController.KeyloggerDetected += ExperimentController_KeyloggerDetected; // Subscribe
            _experimentController.ProcessWriteCount += ExperimentCOntroller_ProcessWriteInfo; // Subscribe to process write count updates
                                                                                              //  injector.StatusUpdate += ExperimentController_StatusUpdated; // Subscribe to injector status updates
                                                                                              //  injector.ProgressUpdate += ExperimentController_ProgressUpdated; // Subscribe to injector progress updates
                                                                                              // Initial UI state
            UpdateStatus($"Ready. Using {algorithm.GetType().Name}.");
            SetButtonsEnabled(true, false); // Initial state: Start enabled, Stop disabled
            UpdateProgressBar(0, 1); // Reset progress bar state
            progressBar1.Visible = false; // Hide progress bar initially
        }

        private void ExperimentCOntroller_ProcessWriteInfo(object? sender, ProcessWriteInfoData e)
        {
            //Debug.WriteLine($" Process Id :{e.Id} \n Process Name:{e.Name}\n Process Count:{e.WriteCount}");
            Process_Scanned.Rows.Add(e.Id, e.Name, e.ExecutablePath, e.WriteCount);
            Process_Scanned.FirstDisplayedScrollingRowIndex = Process_Scanned.Rows.Count - 1;
        }

        private void UpdateProgressBar(int value, int maximum)
        {
            // ToolStripItems don't have InvokeRequired, check the parent StatusStrip
            // if (statusStrip1.InvokeRequired)
            //  {
            //  statusStrip1.BeginInvoke(new Action(() =>
            //  {
            progressBar1.Maximum = Math.Max(1, maximum); // Ensure maximum is at least 1
            progressBar1.Value = Math.Max(0, Math.Min(value, progressBar1.Maximum));
            double percent = ((double)progressBar1.Value / progressBar1.Maximum) * 100; ;// Clamp value
            Debug.WriteLine($"ProgressBar Updated: Value={value}, Maximum={percent}");
            Percentage.Text = $"{percent}%"; // Update percentage text
            progressBar1.Visible = (maximum > 0 && value < maximum); // Show only when running and max is valid
                                                                     // }));
            /*   }
               else
               {
                   progressBar1.Maximum = Math.Max(1, maximum);
                   progressBar1.Value = Math.Max(0, Math.Min(value, progressBar1.Maximum));
                   progressBar1.Visible = (maximum > 0 && value < maximum);
               }*/
        }

        private void SetButtonsEnabled(bool startEnabled, bool stopEnabled)
        {
            if (Start_Button.InvokeRequired)
            {
                Start_Button.BeginInvoke(new Action(() =>
                {
                    Start_Button.Enabled = startEnabled;
                    Stop_Button.Enabled = stopEnabled;
                }));
            }
            else
            {
                Start_Button.Enabled = startEnabled;
                Stop_Button.Enabled = stopEnabled;
            }
        }

        private void UpdateStatus(string message)
        {
            Task_Label.Text = message; // Update status label directly
            /* if (statusStrip1.InvokeRequired)
             {
                 // Use BeginInvoke for potentially better responsiveness if status updates are frequent
                 statusStrip1.BeginInvoke(new Action(() => Task_Label.Text = message));
             }
             else
             {
                 Task_Label.Text = message;
             }*/
        }
        //notification system event handler
        private void ExperimentController_KeyloggerDetected(object? sender, DetectionResult result)
        {
            // Ensure UI updates are on the correct thread
            if (InvokeRequired)
            {
                Invoke(new Action(() => NotificationHelper.ShowDetectionNotification(result)));
            }
            else
            {
                NotificationHelper.ShowDetectionNotification(result);
            }
        }

        private void ExperimentController_ExperimentCompleted(object? sender, List<DetectionResult> results)
        {
            // Ensure UI updates are on the correct thread
            if (InvokeRequired)
            {
                Invoke(new Action(() => ExperimentCompletedUI(results)));
            }
            else
            {
                ExperimentCompletedUI(results);
            }
        }

        private void ExperimentCompletedUI(List<DetectionResult> results)
        {
            SetButtonsEnabled(true, false); // Re-enable Start, disable Stop
            UpdateProgressBar(0, 1); // Reset progress bar
            progressBar1.Visible = false; // Hide progress bar

            int detectedCount = results?.Count(r => r.IsDetected) ?? 0; // Handle null results list defensively
            string message = $"Detection complete. Found {detectedCount} potential keylogger(s) matching criteria.\n\nSee '{_currentConfig.ResultsFilePath}' for details.";
            MessageBoxIcon icon = detectedCount > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information;

            if (DialogResult.OK == MessageBox.Show(this, message, "Detection Complete", MessageBoxButtons.OK, icon))
            {
                DetectionResultActionForm(results);
            }// Specify owner window
            UpdateStatus("Detection Complete. Ready."); // Final status
        }

        private void DetectionResultActionForm(List<DetectionResult> results)
        {

            _dashboardForm.loadform(new DetectionResultActionForm(results)); // Show results in a modal dialog
        }

        private void ExperimentController_ProgressUpdated(object? sender, (int current, int total) progress)
        {
            UpdateProgressBar(progress.current, progress.total);
        }

        private void ExperimentController_StatusUpdated(object? sender, string status)
        {
            UpdateStatus(status);
        }

        
      

       

        private void ScanForm_Load(object sender, EventArgs e)
        {

        }
          
        private async void Start_Button_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to start scanning?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            { 
                SetButtonsEnabled(false, true); // Disable Start, Enable Stop
            UpdateProgressBar(0, 1); // Reset progress bar state
            progressBar1.Visible = true;
            UpdateStatus("Starting experiment...");

            try
            {
                // Ensure controller is initialized
                if (_experimentController == null)
                {
                    InitializeExperiment();
                }
                // Run the experiment asynchronously
                await _experimentController.StartExperimentAsync();
            }
            catch (Exception ex) // Catch unexpected errors during the start sequence or experiment itself
            {
                MessageBox.Show(this, $"An error occurred during the experiment: {ex.Message}", "Experiment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus($"Error: {ex.Message}");
                // Ensure UI is reset correctly on error
                if (!_experimentController.IsRunning) // Check if controller already reset state
                {
                    SetButtonsEnabled(true, false);
                    progressBar1.Visible = false;
                }
            }
            }
            else
            {
                MessageBox.Show("Scanning cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to stop the scanning process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _experimentController?.StopExperiment();
                // UI updates (status, buttons) will be handled by the cancellation/completion events from the controller.
                UpdateStatus("Stop requested..."); // Give immediate feedback
                Stop_Button.Enabled = false; // Disable stop button immediately after clicking
                MessageBox.Show(this, "Scanning process has been stopped.", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        
    }
}
