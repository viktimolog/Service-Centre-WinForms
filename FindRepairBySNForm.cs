using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCentre
{
    public partial class FindRepairBySNForm : Form
    {
        public FindRepairBySNForm()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try { main.sN = textBox_SN.Text; }

            catch { main.sN = ""; }
            this.Close();
        }
    }
}
