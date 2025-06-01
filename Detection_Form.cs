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
using VisualKeyloggerDetector.Core.PatternGeneration;

namespace KLDS
{
    public partial class Detection_Form : Form
    {
        public Detection_Form()
        {
            InitializeComponent();
            InitializeSettings();
        }

        public void InitializeSettings()
        {
            string Setting_file_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_Configuration.json");

            String setting = File.ReadAllText(Setting_file_Path);
            ExperimentConfiguration _config = JsonSerializer.Deserialize<ExperimentConfiguration>(setting, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            Algorithm.SelectedIndex = _config.index_algo;
            Number_of_Interval.Text = _config.PatternLengthN.ToString();
            DUration_Of_Interval.Text = _config.IntervalDurationT.ToString();
            Key_Max.Text = _config.MaxKeysPerIntervalKmax.ToString();
            Key_Min.Text = _config.MinKeysPerIntervalKmin.ToString();
            
        }
        private void Detection_Form_Load(object sender, EventArgs e)
        {
            string Setting_file_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_Configuration.json");

            String setting = File.ReadAllText(Setting_file_Path);
            ExperimentConfiguration _config = JsonSerializer.Deserialize<ExperimentConfiguration>(setting, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            Algorithm.SelectedIndex = _config.index_algo;
            Number_of_Interval.Text = _config.PatternLengthN.ToString();
            DUration_Of_Interval.Text = _config.IntervalDurationT.ToString();
            Key_Max.Text = _config.MaxKeysPerIntervalKmax.ToString();
            Key_Min.Text = _config.MinKeysPerIntervalKmin.ToString();

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the settings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                ExperimentConfiguration _config = new ExperimentConfiguration();
                _config.PatternLengthN = int.Parse(Number_of_Interval.Text);
                _config.IntervalDurationT = int.Parse(DUration_Of_Interval.Text);
                _config.MaxKeysPerIntervalKmax = int.Parse(Key_Max.Text);
                _config.MinKeysPerIntervalKmin = int.Parse(Key_Min.Text);
                _config.index_algo = Algorithm.SelectedIndex;
                Debug.WriteLine($"Selected Algorithm Index: {_config.index_algo}");
            
                Debug.WriteLine($"Algortithm selected {Algorithm.SelectedIndex}");
                string Serialized_Setting = JsonSerializer.Serialize(_config, new JsonSerializerOptions { WriteIndented = true });
                string Setting_file_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_Configuration.json");

                // Correctly write the JSON content to the file
                File.WriteAllText(Setting_file_Path, Serialized_Setting);
                MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Settings not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
