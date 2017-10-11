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
    public partial class AddModelForm : Form
    {
        private Device device;
        private SQLActions sql;
        public AddModelForm(Device device = null)
        {
            InitializeComponent();
            this.device = device;
            sql = new SQLActions();
        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {
            //Load Categories
            comboBox_Categories.DataSource = sql.getCategoriesAll();
            comboBox_Categories.DisplayMember = "nameCategory";
            comboBox_Categories.ValueMember = "nameCategory";
            if (device != null) comboBox_Categories.Text = device.Category;


            //Load BrandsByCategory
            comboBox_Brands.DataSource = sql.getBrandsByCategoryAll(comboBox_Categories.Text);
            comboBox_Brands.DisplayMember = "nameBrand";
            comboBox_Brands.ValueMember = "nameBrand";
            if (device != null) comboBox_Brands.Text = device.Brand;
        }

        private void bt_AddModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (device == null) device = new Device();
                device.Category = comboBox_Categories.Text;
                device.Brand = comboBox_Brands.Text;
                device.Model = textBox1.Text;
                (new SQLActions()).AddModel(textBox1.Text, comboBox_Brands.Text, comboBox_Categories.Text);
                MessageBox.Show("Добавлена новая модель: " + textBox1.Text + " бренда " + comboBox_Brands.Text + " в категории " + comboBox_Categories.Text, "Успешное добавление модели");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }

        private void comboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load BrandsByCategory
            comboBox_Brands.DataSource = sql.getBrandsByCategoryAll(comboBox_Categories.Text);
            comboBox_Brands.DisplayMember = "nameBrand";
            comboBox_Brands.ValueMember = "nameBrand";
         //   if (device != null) comboBox_Brands.Text = device.Brand;
        }
    }
}
