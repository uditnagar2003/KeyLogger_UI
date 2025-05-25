using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLDS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
