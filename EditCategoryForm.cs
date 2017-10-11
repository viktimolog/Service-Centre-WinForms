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
    public partial class EditCategoryForm : Form
    {
        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            bt_Save.Enabled = false;

            List<string> categories = new List<string>();
            categories = (new SQLActions()).getCategories();
            for(int i=0;i<categories.Count;i++)
            {
                comboBox1.Items.Add(categories[i]);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            bt_Save.Enabled = true;

            comboBox1.Enabled = false;
            bt_Edit.Enabled = false;

            textBox1.Text = comboBox1.Text;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                (new SQLActions()).EditCategory(comboBox1.Text, textBox1.Text);
                MessageBox.Show("Категория " + comboBox1.Text + " изменена на " + textBox1.Text, "Успешное изменение категории");
            }
            catch
            {
                MessageBox.Show("Not connected to DB","Error");
            }
            this.Close();
        }
    }
}
