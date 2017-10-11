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
    public partial class FindRepairByNumberForm : Form
    {
        public FindRepairByNumberForm()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try { main.IdFindRepair = Convert.ToInt32(textBox_NumberRepair.Text); }

            catch { main.IdFindRepair = 0; }
            this.Close();
        }

        private void FindRepairByNumberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
