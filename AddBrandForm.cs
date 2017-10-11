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
    public partial class AddBrandForm : Form
    {
    /*    private string cat;
        private string nameBrand;*/
        private Device device;
        private SQLActions sql;
        public AddBrandForm(Device device=null)
        {
            InitializeComponent();
            this.device = device;
            sql = new SQLActions();
        }

        private void AddBrandForm_Load(object sender, EventArgs e)
        {
            //Load Categories
            List<Category> categories = new List<Category>();
            categories = sql.getCategoriesAll();
            comboBox_Categories.DataSource = categories;
            comboBox_Categories.DisplayMember = "nameCategory";
            comboBox_Categories.ValueMember = "nameCategory";
            if (device != null) comboBox_Categories.Text = device.Category;
        }

        private void bt_AddBrand_Click(object sender, EventArgs e)
        {
            try
            {
                if (device == null) device = new Device();
                device.Brand = textBox1.Text;
                sql.AddBrand(textBox1.Text, comboBox_Categories.Text);
                MessageBox.Show("Добавлен новый бренд: " + textBox1.Text + " в категории " + comboBox_Categories.Text, "Успешное добавление бренда");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }
    }
}
