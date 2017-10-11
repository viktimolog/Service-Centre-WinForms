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
    public partial class AddCategoryForm : Form
    {
        private Device device;
        private SQLActions sql;
        public AddCategoryForm(Device device = null)
        {
            InitializeComponent();
            this.device = device;
            sql = new SQLActions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (device == null) device = new Device();
                device.Category = textBox1.Text;
                (new SQLActions()).AddCategory(textBox1.Text);
                MessageBox.Show("Добавлена новая категория: " + textBox1.Text, "Успешное добавление категории");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }
    }
}
