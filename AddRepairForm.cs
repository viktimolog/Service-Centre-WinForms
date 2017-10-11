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
    public partial class AddRepairForm : Form
    {
        private Controller controller;
        private SQLActions sql;
        private Client client;
        private Device device;
        public AddRepairForm()
        {
            InitializeComponent();
            controller = new Controller();
            sql = new SQLActions();
            client = null;
            device = null;
        }

        public void LoadClients()
        {
            //Load Clients          
            List<Client> clients = sql.getClients();
            comboBox_nameClient.DataSource = clients;
            comboBox_nameClient.DisplayMember = "nameClient";
            comboBox_nameClient.ValueMember = "nameClient";
            if (client != null)            
            {
                  comboBox_nameClient.Text = client.NameClient;
                  textBox_Contact.Text = client.Contact;
                  textBox_Phone.Text = client.Phone;
                  textBox_Address.Text = client.Address;
                  textBox_Email.Text = client.Email;
              }
            clients = null;
        }

        public void LoadCategories()
        {
            //Load Categories
            List<Category> categories = sql.getCategoriesAll();
            comboBox_Categories.DataSource = categories;
            comboBox_Categories.DisplayMember = "nameCategory";
            comboBox_Categories.ValueMember = "nameCategory";
            if (device != null) comboBox_Categories.Text = device.Category;
            categories = null;
        }

        public void LoadBrandsByCategory()
        {
            List<Brand> brands = sql.getBrandsByCategoryAll(comboBox_Categories.Text);
            comboBox_Brands.DataSource = brands;
            comboBox_Brands.DisplayMember = "nameBrand";
            comboBox_Brands.ValueMember = "nameBrand";
            if (device != null) comboBox_Brands.Text = device.Brand;
            brands = null;
        }
        public void LoadModelByCategoryAndBrand()
        {
            List<Model>models = sql.getModelByCategoryAndBrandAll(comboBox_Categories.Text, comboBox_Brands.Text);
            comboBox_Model.DataSource = models;
            comboBox_Model.DisplayMember = "nameModel";
            comboBox_Model.ValueMember = "nameModel";
            if (device != null) comboBox_Model.Text = device.Model;
            models = null;
        }

        public void LoadEngineers()
        {
            //Load Engineers
            List<Engineer> engineers = sql.getEngineersAll();
            comboBox_Engineer.DataSource = engineers;
            comboBox_Engineer.DisplayMember = "nameEngineer";
            comboBox_Engineer.ValueMember = "nameEngineer";
            engineers = null;
        }

        public void LoadStatusRepairs()
        {
            List<StatusRepair> statusesRepairs = sql.getStatusAll();
            comboBox_StatusRepair.DataSource = statusesRepairs;
            comboBox_StatusRepair.DisplayMember = "nameStatus";
            comboBox_StatusRepair.ValueMember = "nameStatus";
            //comboBox_StatusRepair.Text = "В работе";
            statusesRepairs = null;
        }

        public void LoadTypesRepairs()
        {
            List<TypeRepair>typesRepairs = sql.getTypesAll();
            comboBox_TypeRepair.DataSource = typesRepairs;
            comboBox_TypeRepair.DisplayMember = "nameType";
            comboBox_TypeRepair.ValueMember = "nameType";
           // comboBox_TypeRepair.Text = "Не гарантийный";
            typesRepairs = null;
        }
        public void loadAddRepairForm(Client client = null, Device device = null)
        {
            this.client = client;
            this.device = device;
            //Load Clients     
            LoadClients();


            //Load Categories
            LoadCategories();


            //Load BrandsByCategory
            LoadBrandsByCategory();


            //Load getModelByCategoryAndBrand
            LoadModelByCategoryAndBrand();


            //Load Engineers
            LoadEngineers();


            //Load StatusRepairs
            LoadStatusRepairs();


            //Load TypesRepairs
            LoadTypesRepairs();

            comboBox_Engineer.Text = "Коганов";
            comboBox_TypeRepair.Text = "Не гарантийный";
            comboBox_Categories.Text = "Ноутбук";
        }
        public Client getClient()
        {
            client.NameClient = comboBox_nameClient.Text;
            client.Contact = textBox_Contact.Text;
            client.Phone = textBox_Phone.Text;
            client.Address = textBox_Address.Text;
            client.Email = textBox_Email.Text;
            return client;
        }

        public Device getDevice()
        {
            device.Category = comboBox_Categories.Text;
            device.Brand = comboBox_Brands.Text;
            device.Model = comboBox_Model.Text;
            return device;
        }
        private void AddRepairForm_Load(object sender, EventArgs e)
        {
            loadAddRepairForm();
        }

        public void bt_AddClient_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();//нужен пустой
            (new AddClientForm(newClient)).ShowDialog();
            try
            {
                loadAddRepairForm(newClient);
            }
            catch { loadAddRepairForm(); }
        }

        public void bt_EditClient_Click(object sender, EventArgs e)
        {
            if (client == null) client = new Client();
            client = getClient();

            (new EditClientForm(client)).ShowDialog();

            loadAddRepairForm(client);
        }
        public void comboBox_nameClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            textsforTextboxes((Client)comboBox_nameClient.SelectedItem);
        }

        public void comboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load BrandsByCategory
            LoadBrandsByCategory();


            //Load getModelByCategoryAndBrand
            LoadModelByCategoryAndBrand();
        }

        public void comboBox_Brands_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Load getModelByCategoryAndBrand
            LoadModelByCategoryAndBrand();
        }

        private void bt_SaveNewRepair_Click(object sender, EventArgs e)
        {
            int price = 0;
            try
            {
                price = Convert.ToInt32(textBox_Price.Text);
            }
            catch
            {
                price = 0;
                //MessageBox.Show("Цена установлена 0", "Неккоректно введена цена!");
            }

            try
            {
                (new SQLActions()).AddRepair(comboBox_nameClient.Text, comboBox_Categories.Text, comboBox_Brands.Text, comboBox_Model.Text
                    , textBox_SN.Text, comboBox_TypeRepair.Text, textBox_Defect.Text, textBox_kitView.Text, comboBox_Engineer.Text
                    , textBox_Result.Text, price, comboBox_StatusRepair.Text);
                // MessageBox.Show("Ремонт добавлен успешно!", "Успешное добавление нового ремонта");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }

        public void bt_NewModel_Click(object sender, EventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddModelForm(device)).ShowDialog();
            //Load getModelByCategoryAndBrand
            LoadModelByCategoryAndBrand();
        }

        public void bt_NewBrand_Click(object sender, EventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddBrandForm(device)).ShowDialog();

            //Load BrandsByCategory
            LoadBrandsByCategory();
        }

        public void bt_NewCategory_Click(object sender, EventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddCategoryForm(device)).ShowDialog();

            //Load Categories
            LoadCategories();
        }

        private void bt_EditContact_Click(object sender, EventArgs e)
        {
            (new EditClientForm((Client)comboBox_nameClient.SelectedItem)).ShowDialog();
        }

        public void textsforTextboxes(Client client)
        {
            textBox_Contact.Text = client.Contact;
            textBox_Phone.Text = client.Phone;
            textBox_Address.Text = client.Address;
            textBox_Email.Text = client.Email;
        }

        private void comboBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_TypeRepair_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Engineer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_StatusRepair_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
