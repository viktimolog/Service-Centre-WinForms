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
    public partial class EditModelForm : Form
    {
        private Controller controller;
        private List<string> tmp;
        public EditModelForm()
        {
            InitializeComponent();
            controller = new Controller();
        }


        public void loadEditModelForm()
        {
            //Load Categories--------------

            controller.loadComboBoxWithoutParam(comboBox_Categories, "getCategories");


            //Load BrandsByCategory-----------------

            controller.loadComboBoxBrandsByCategory(comboBox_Brands, comboBox_Categories.Text);


            //Load getModelByCategoryAndBrand----------------

            controller.loadComboBoxModelsByBrandsAndCategory(comboBox_Model, comboBox_Categories.Text, comboBox_Brands.Text);

            textBox_newNameModel.Text = comboBox_Model.Text;

        }
        private void EditModelForm_Load(object sender, EventArgs e)
        {
            loadEditModelForm();
        }

        private void comboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load BrandsByCategory-----------------

            controller.loadComboBoxBrandsByCategory(comboBox_Brands, comboBox_Categories.Text);


            //Load getModelByCategoryAndBrand----------------

            controller.loadComboBoxModelsByBrandsAndCategory(comboBox_Model, comboBox_Categories.Text, comboBox_Brands.Text);

            textBox_newNameModel.Text = comboBox_Model.Text;

        }

        private void comboBox_Brands_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load getModelByCategoryAndBrand----------------

            controller.loadComboBoxModelsByBrandsAndCategory(comboBox_Model, comboBox_Categories.Text, comboBox_Brands.Text);

            textBox_newNameModel.Text = comboBox_Model.Text;
        }

        private void comboBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_newNameModel.Text = comboBox_Model.Text;
        }

        private void bt_SaveModel_Click(object sender, EventArgs e)
        {
            try
            {
               bool ok =  (new SQLActions()).EditModel(comboBox_Model.Text, textBox_newNameModel.Text, comboBox_Categories.Text, comboBox_Brands.Text);
                if(ok) MessageBox.Show("Данные модели успешно изменены!");
                else MessageBox.Show("Такая модель уже существует!");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }
    }
}
