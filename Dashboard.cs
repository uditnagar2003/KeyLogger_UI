using Client_Library;
using keylogger_lib.DTO;
using keylogger_lib.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLDS
{
    public partial class Dashboard : Form
    {
        KeyLogService keyLogService = new KeyLogService();
        DashboardForm dashboardForm;
        public Dashboard(DashboardForm fom)
        {
            InitializeComponent();
            dashboardForm = fom;

            //comboBox1.SelectedItem = comboBox1.Items[0];
            User_id.Text = User_Session.UserId.ToString();
            User_Name.Text = User_Session.Name;
            createGraphicsColumn();
            InitailizeTable();

            Panel verticalMask = new Panel
            {
                Width = SystemInformation.VerticalScrollBarWidth,
                Height = Key_Log.Height,
                Left = Key_Log.Right - SystemInformation.VerticalScrollBarWidth,
                Top = Key_Log.Top,
                BackColor = Key_Log.BackgroundColor, // Or match DataGridView background
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom
            };
            Debug.WriteLine("Execueting table panel"+verticalMask.Width);
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
            Key_Log.Columns.Insert(0, iconColumn);
        }

        private async Task InitailizeTable()
        {
            List<KeyLoggerInfo> keylog = await keyLogService.GetKeyLogsAsync(User_Session.UserId);
            int totalKeyLogs = keylog.Count;
            int suspendedKeyLogs = keylog.Count(x => x.Status == "Suspended");
            Debug.WriteLine("Suspended Key Logs: " + suspendedKeyLogs);
            int activeKeyLogs = keylog.Count(x => x.Status == "Active");
            System.Drawing.Image image = System.Drawing.Image.FromFile("E:\\final project\\KLDS_UI\\virus (1).png");
            if (keylog != null && keylog.Count > 0)
            {
               int i = 0;
                foreach (var result in keylog)
                {
                    //  var row = new DataGridViewRow();
                 
                    //    row.CreateCells(result.ProcessId, result.ProcessName, result.ExecutablePath, result.Correlation);
                    Key_Log.Rows.Add(image,result.process_id.ToString(), result.Process_Name, result.Location, result.Detection_Time, result.Status);
                    setcolor(i, result.Status);
                    i++;
                }
            }
            else
            {
                MessageBox.Show("No key logs found for this user.");
            }
            Total.Text = totalKeyLogs.ToString();
            Suspended.Text = suspendedKeyLogs.ToString();
            Active.Text = activeKeyLogs.ToString();
          

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }


        private void setcolor(int i,string status)
        {
           if(status == "Suspended")
            {
                Key_Log.Rows[i].Cells[5].Style.ForeColor = Color.Green;
            }
            else
            {
                Key_Log.Rows[i].Cells[5].Style.ForeColor = Color.Red;
            }
           
        }

        private void Key_Log_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = Key_Log.Rows[e.RowIndex].Cells[5];
            if (cell.Value.ToString() == "Suspended")
            {
                cell.Style.SelectionForeColor = Color.Green;
            }
            else
            {
               
                cell.Style.SelectionForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm.loadform(new ScanForm(dashboardForm));
        }

        
    }
}
