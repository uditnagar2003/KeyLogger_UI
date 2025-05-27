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

namespace KLDS
{
    public partial class DetectionResultActionForm : Form
    {
        private List<DetectionResult> _results;
        public DetectionResultActionForm(List<DetectionResult> results)
        {
            _results = results;
            InitializeComponent();
            InitializeTable();
        }

        private void InitializeTable()
        {
            /* string Setting_file_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_Configuration.json");

             String setting = File.ReadAllText(Setting_file_Path);
             ExperimentConfiguration _config = JsonSerializer.Deserialize<ExperimentConfiguration>(setting, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
           */
            foreach (var result in _results)
            {
                //  var row = new DataGridViewRow();
                //    row.CreateCells(result.ProcessId, result.ProcessName, result.ExecutablePath, result.Correlation);
                if (result.IsDetected)
                    Detected_Table.Rows.Add(result.ProcessId, result.ProcessName, result.ExecutablePath, result.Correlation, "ignored");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DetectionResultActionForm_Load(object sender, EventArgs e)
        {

        }

        private void Detected_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            Debug.WriteLine("selectedRowIndex"+selectedRowIndex);
            ProcesId.Text = Detected_Table.Rows[selectedRowIndex].Cells[0].Value.ToString();
            ProcessName.Text = Detected_Table.Rows[selectedRowIndex].Cells[1].Value.ToString();


        }

        private void Suspend_Button_Click_1(object sender, EventArgs e)
        {
            int selectedRowIndex = Detected_Table.SelectedRows[0].Index;
            Detected_Table.Rows[selectedRowIndex].Cells[4].Value = "suspended";
        }

        private void Ignore_Button_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = Detected_Table.SelectedRows[0].Index;
            Detected_Table.Rows[selectedRowIndex].Cells[4].Value = "Ignore";
        }
    }
}
