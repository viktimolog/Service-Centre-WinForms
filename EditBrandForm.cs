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
    public partial class EditBrandForm : Form
    {
        List<string> brands;
        List<string> categoriesBrands;
        public EditBrandForm()
        {
            InitializeComponent();
            brands = new List<string>();
            categoriesBrands = new List<string>();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
             try
             {
                int i = comboBox_Brands.SelectedIndex;
                 (new SQLActions()).EditBrand(brands[i], categoriesBrands[i], textBox_nameBrand.Text, comboBox_Categories.Text);
                 MessageBox.Show("Бренд успешно изменен!");
             }
             catch
             {
                 MessageBox.Show("Not connected to DB", "Error");
             }
             this.Close();
        }

        private void EditBrandForm_Load(object sender, EventArgs e)
        {
            textBox_nameBrand.Enabled = false;
            bt_Save.Enabled = false;
            comboBox_Categories.Enabled = false;

            (new SQLActions()).getAllBrendsWithCategories(brands, categoriesBrands);
            for (int i = 0; i < brands.Count; i++)
            {
                comboBox_Brands.Items.Add(brands[i] + " - " + categoriesBrands[i]);
            }
            comboBox_Brands.SelectedIndex = 0;

            List<string> categories = new List<string>();
            categories = (new SQLActions()).getCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                comboBox_Categories.Items.Add(categories[i]);
            }
            comboBox_Categories.SelectedIndex = 0;
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            comboBox_Categories.Enabled = true;
            textBox_nameBrand.Enabled = true;
            textBox_nameBrand.Text = brands[comboBox_Brands.SelectedIndex];
            comboBox_Categories.Text = categoriesBrands[comboBox_Brands.SelectedIndex];
            bt_Save.Enabled = true;       
        }
    }
}

