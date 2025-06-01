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
using VisualKeyloggerDetector;
using VisualKeyloggerDetector.Core;

namespace KLDS
{
    public partial class DetectionResultActionForm : Form
    {
        private List<DetectionResult> _results;
        private KeyLogService keyLogService = new KeyLogService();
        private List<KeyLoggerInfo> _keyLoggerInfos = new List<KeyLoggerInfo>();


        public DetectionResultActionForm(List<DetectionResult> results)
        {
            _results = results;
            InitializeComponent();
            createGraphicsColumn();
            InitializeTable();
            Panel verticalMask = new Panel
            {
                Width = SystemInformation.VerticalScrollBarWidth,
                Height = Detected_Table.Height,
                Left = Detected_Table.Right - SystemInformation.VerticalScrollBarWidth,
                Top = Detected_Table.Top,
                BackColor = Detected_Table.BackgroundColor, // Or match DataGridView background
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom
            };
            Debug.WriteLine("Execueting table panel" + verticalMask.Width);
            this.Controls.Add(verticalMask);
            verticalMask.BringToFront();
        }
        private void createGraphicsColumn()
        {
            // Icon treeIcon = new Icon(this.GetType(), "tree.ico");
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            //iconColumn.Image = treeIcon.ToBitmap();
            iconColumn.Name = "tree";
            iconColumn.HeaderText = "";
            iconColumn.Width = 20; // Set the width of the icon column
            iconColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Detected_Table.Columns.Insert(0, iconColumn);
        }

        private void InitializeTable()
        {
            /* string Setting_file_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_Configuration.json");

             String setting = File.ReadAllText(Setting_file_Path);
             ExperimentConfiguration _config = JsonSerializer.Deserialize<ExperimentConfiguration>(setting, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
           */
            System.Drawing.Image image = System.Drawing.Image.FromFile("E:\\final project\\KLDS_UI\\virus (1).png");
            int i= 0;
            foreach (var result in _results)
            {
                //  var row = new DataGridViewRow();
                //    row.CreateCells(result.ProcessId, result.ProcessName, result.ExecutablePath, result.Correlation);
                if (result.IsDetected)
                {
                    Detected_Table.Rows.Add(image, result.ProcessId, result.ProcessName, result.ExecutablePath, result.Correlation,result.DetectionTime, "Active");
                    setcolor(i, "Active");
                    i++;
                }

            }
            foreach (var result in _results)
            {
                // Log the ignored keylogger information 
                KeyLoggerInfo info = new KeyLoggerInfo()
                {
                    process_id = result.ProcessId,
                    Process_Name = result.ProcessName,
                    Location = result.ExecutablePath,
                    Detection_Time = result.DetectionTime,
                    User_Id = User_Session.UserId,
                    Action = "Ignored",
                    Status = "Active"
                };
                _keyLoggerInfos.Add(info);

            }
        }

        private void setcolor(int i, string status)
        {
            if (status == "Suspended")
            {
                Detected_Table.Rows[i].Cells[6].Style.ForeColor = Color.Green;
            }
            else
            {
                Detected_Table.Rows[i].Cells[6].Style.ForeColor = Color.Red;
            }

        }

        private void DetectionResultActionForm_Load(object sender, EventArgs e)
        {

        }

        private void Detected_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int selectedRowIndex = e.RowIndex;
            Debug.WriteLine("selectedRowInde detected tablex" + selectedRowIndex);
            ProcesId.Text = Detected_Table.Rows[selectedRowIndex].Cells[1].Value.ToString();
            ProcessName.Text = Detected_Table.Rows[selectedRowIndex].Cells[2].Value.ToString();
            var cell = Detected_Table.Rows[selectedRowIndex].Cells[6];
           // Detected_Table.CurrentCell = null;
           

            if (cell.Value =="Suspended")
            {
                cell.Style.SelectionForeColor = Color.Green;
            }
            else
            {
                cell.Style.SelectionForeColor = Color.Red;
            }

        }

        private void Suspend_Button_Click_1(object sender, EventArgs e)
        {
            int selectedRowIndex = Detected_Table.SelectedRows[0].Index;
            int id = Convert.ToInt32(Detected_Table.Rows[selectedRowIndex].Cells[1].Value);
            foreach (var info in _keyLoggerInfos)
            {
                var processInfo = ProcessMonitor.GetProcessById(id);
                if (info.process_id == id)
                {

                    info.Action = "Suspended";
                    info.Status = "Suspended";
                    Detected_Table.Rows[selectedRowIndex].Cells[6].Value = "Suspended";
                    setcolor(selectedRowIndex,"Suspended");


                }
            }


        }

        private void Ignore_Button_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the results?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                foreach (var res in _keyLoggerInfos)

                {
                    keyLogService.SendKeyLogAsync(res).ContinueWith(task =>
                    {
                        if (task.IsCompletedSuccessfully)
                        {
                            Debug.WriteLine("Keylogger info sent successfully: " + res.Process_Name);
                        }
                        else
                        {
                            Debug.WriteLine("Failed to send keylogger info: " + res.Process_Name);
                        }
                    });

                }
                //MessageBox.Show("Detected Keylogger information sent successfully!");
                MessageBox.Show("Detected Keylogger information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Results not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Skip the last row if it's a new row (used for inserting new data)

            // Detected_Table.Rows[selectedRowIndex].Cells[4].Value = "Ignore";
        }

       
        
    }
}
