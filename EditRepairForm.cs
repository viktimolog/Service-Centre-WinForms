using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCentre
{
    public partial class EditRepairForm : Form
    {
        private int idRepair;
        private Controller controller;
        private SQLActions sql;
        private Client client;
        private Device device;
        private Repair repair;
        public EditRepairForm(int idRepair)
        {
            InitializeComponent();
            controller = new Controller();
            sql = new SQLActions();
            client = null;
            device = null;
            repair = new Repair();
            this.idRepair = idRepair;
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
            List<Model> models = sql.getModelByCategoryAndBrandAll(comboBox_Categories.Text, comboBox_Brands.Text);
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
            List<TypeRepair> typesRepairs = sql.getTypesAll();
            comboBox_TypeRepair.DataSource = typesRepairs;
            comboBox_TypeRepair.DisplayMember = "nameType";
            comboBox_TypeRepair.ValueMember = "nameType";
            // comboBox_TypeRepair.Text = "Не гарантийный";
            typesRepairs = null;
        }

        private void EditRepairForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(idRepair.ToString());
            loadEditRepairForm(client, device);
        }

        private void bt_EditClient_Click(object sender, EventArgs e)
        {
            if (client == null) client = new Client();
            client = getClient();

            (new EditClientForm(client)).ShowDialog();

            loadEditRepairForm(client);
        }

        private void bt_AddClient_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();//нужен пустой
            (new AddClientForm(newClient)).ShowDialog();
               loadEditRepairForm(newClient);
        }
        public void loadEditRepairForm(Client client = null, Device device = null)
        {
            this.client = client;
            this.device = device;
            //Load Repair number
            textBox_Number.Text = idRepair.ToString();

            //Load Date
            textBox_Date.Text = (sql.getDateByIdRepair(idRepair)).ToString();

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

            //get Repair
            if (client == null && device == null)
            {

                comboBox_nameClient.Text = sql.getNameClientByIdRepair(idRepair);
                textsforTextboxes((Client)comboBox_nameClient.SelectedItem);

                sql.getRepair(idRepair, repair);

                textBox_SN.Text = repair.SN;
                textBox_Defect.Text = repair.Defect;
                textBox_kitView.Text = repair.KitView;
                textBox_Result.Text = repair.Result;
                textBox_Price.Text = repair.Price.ToString();

                comboBox_Categories.Text = sql.getNameCategoryByIdModel(repair.IdModel);

                comboBox_Brands.Text = sql.getNameBrandByIdModel(repair.IdModel);

                comboBox_Model.Text = sql.getNameModelByIdModel(repair.IdModel);

                comboBox_Engineer.Text = sql.getEngineerById(repair.IdEngineer);

                comboBox_StatusRepair.Text = sql.getStatusById(repair.IdStatus);

                comboBox_TypeRepair.Text = sql.getTypeRepairById(repair.IdType);
            }

        }
        public void textsforTextboxes(Client client)
        {
            textBox_Contact.Text = client.Contact;
            textBox_Phone.Text = client.Phone;
            textBox_Address.Text = client.Address;
            textBox_Email.Text = client.Email;
        }

        private void comboBox_nameClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            textsforTextboxes((Client)comboBox_nameClient.SelectedItem);
        }

        private void comboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load BrandsByCategory
            LoadBrandsByCategory();


            //Load getModelByCategoryAndBrand
            LoadModelByCategoryAndBrand();
        }

        private void comboBox_Brands_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load getModelByCategoryAndBrand
            LoadModelByCategoryAndBrand();
        }

        private void bt_NewCategory_Click(object sender, EventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddCategoryForm(device)).ShowDialog();

            //Load Categories
            LoadCategories();
        }

        private void bt_NewBrand_Click(object sender, EventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddBrandForm(device)).ShowDialog();

            //Load BrandsByCategory
            LoadBrandsByCategory();
        }

        private void bt_NewModel_Click(object sender, EventArgs e)
        {
            if (device == null) device = new Device();
            device = getDevice();
            (new AddModelForm(device)).ShowDialog();
            //Load getModelByCategoryAndBrand
            LoadModelByCategoryAndBrand();
        }

        private void bt_SaveRepair_Click(object sender, EventArgs e)
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
                sql.EditRepair(repair.IdRepair, comboBox_nameClient.Text, comboBox_Categories.Text, comboBox_Brands.Text, comboBox_Model.Text
                    , textBox_SN.Text, comboBox_TypeRepair.Text, textBox_Defect.Text, textBox_kitView.Text, comboBox_Engineer.Text
                    , textBox_Result.Text, price, comboBox_StatusRepair.Text);
                // MessageBox.Show("Ремонт изменен успешно!", "Успешное изменение нового ремонта");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }
        public void bt_Print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.PrintPage += new PrintPageEventHandler(PRD);
                    printDocument1.DocumentName = "Order"; //Названия документа
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;//Передаем параметры
                    printDocument1.Print();//Начинаем процесс печати
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        public string Order()
        {
            string order = "";
            order += "\t\t     Квитанция о приеме в ремонт № " + textBox_Number.Text + " от " + textBox_Date.Text + "\n\n";
            order += "Сервисный центр: ВСЕСВИТ\n";
            order += "Адрес: г.Запорожье, ул.Независимой Украины 39\n";
            order += "Телефон: (061)-220-96-19\n\n";
            order += "Заказчик: " + comboBox_nameClient.Text + "\n";
            order += "Контактное лицо: " + textBox_Contact.Text + "\n";
            order += "Телефон: " + textBox_Phone.Text + "\n";
            order += "Адрес: " + textBox_Address.Text + "\n";
            order += "E-mail: " + textBox_Email.Text + "\n\n";

            order += "Изделие: " + comboBox_Categories.Text + " " + comboBox_Brands.Text + " " + comboBox_Model.Text + "\n";
            order += "Серийный номер: " + textBox_SN.Text + "\n";
            order += "Тип ремонта: " + comboBox_TypeRepair.Text + "\n";
            order += "Дефект: " + textBox_Defect.Text + "\n";
            order += "Комплектность, описание: " + textBox_kitView.Text + "\n\n";
            order += "Заказчик дает согласие на сбор и обработку своих персональных данных.\n" + "Заказчик уведомлен, что сервисный центр не несет ответственность за сохранность информации,\n"
                + "как на устройстве, так и на любых других видах носителей информации.\n\n";
            order += "Подпись заказчика:____________________" + "\t" + "Подпись приемщика:____________________" + "\n\n\n";
            order += "------------------------------------------------------------------------------------------------------------------------------------------\n\n";


            order += "\t\t     Квитанция о приеме в ремонт № " + textBox_Number.Text + " от " + textBox_Date.Text + "\n\n";
            order += "Сервисный центр: ВСЕСВИТ\n";
            order += "Адрес: г.Запорожье, ул.Независимой Украины 39\n";
            order += "Телефон: (061)-220-96-19\n\n";
            order += "Заказчик: " + comboBox_nameClient.Text + "\n";
            order += "Контактное лицо: " + textBox_Contact.Text + "\n";
            order += "Телефон: " + textBox_Phone.Text + "\n";
            order += "Адрес: " + textBox_Address.Text + "\n";
            order += "E-mail: " + textBox_Email.Text + "\n\n";

            order += "Изделие: " + comboBox_Categories.Text + " " + comboBox_Brands.Text + " " + comboBox_Model.Text + "\n";
            order += "Серийный номер: " + textBox_SN.Text + "\n";
            order += "Тип ремонта: " + comboBox_TypeRepair.Text + "\n";
            order += "Дефект: " + textBox_Defect.Text + "\n";
            order += "Комплектность, описание: " + textBox_kitView.Text + "\n\n";

            order += "Инженер: " + comboBox_Engineer.Text + "\n";
            order += "Состояние ремонта: " + comboBox_StatusRepair.Text + "\n\n";

            order += "Результат: " + textBox_Result.Text + "\n";
            order += "1.\n";
            order += "2.\n";
            order += "3.\n";
            order += "4.\n";
            order += "5.\n";
            order += "6.\n";
            order += "7.\n\n";

            order += "Стоимость ремонта: ";

            return order;
        }
        public void PRD(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString(Order(), new Font("Arial", 12), new SolidBrush(Color.Black), 0, 0);
        }//Конец печати
    }
}
