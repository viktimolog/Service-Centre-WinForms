using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCentre
{
    public class Controller
    {
        private Client client;
        private SQLActions sql;
        private List<string> tmp;
    /*    private AddRepairForm formAddRepair;
        private EditRepairForm formEditRepair;
        private AddClientForm formAddClient;*/
        private Form form;

        public Controller()
        {
            sql = new SQLActions();
            client = new Client();
        }

        public void LoadClientsToForm(AddRepairForm formAddRepair = null, EditRepairForm formEditRepair = null, AddClientForm formAddClient = null)
        {
            // form = formAddRepair;
            /*   if (formAddRepair != null)
               {
                   form = new AddRepairForm();
                   form = formAddRepair;
               }*/


            /*  else if(formEditRepair != null) form = formEditRepair;
              else if (formAddClient != null) form = formAddClient;*/

            /*  form = new AddRepairForm();

              (AddRepairForm)form.comboBox_nameClient.DataSource = sql.getClients();*/

            Convert.ChangeType(form, typeof(AddRepairForm));

     //       form.comboBox_nameClient.DataSource = sql.getClients();


            formAddRepair.comboBox_nameClient.DataSource = sql.getClients();

            formAddRepair.comboBox_nameClient.DisplayMember = "nameClient";
            formAddRepair.comboBox_nameClient.ValueMember = "nameClient";
            if (client != null)
            {
                formAddRepair.comboBox_nameClient.Text = client.NameClient;
                formAddRepair.textBox_Contact.Text = client.Contact;
                formAddRepair.textBox_Phone.Text = client.Phone;
                formAddRepair.textBox_Address.Text = client.Address;
                formAddRepair.textBox_Email.Text = client.Email;
            }
        }

  /*      public Client getClient()
        {
            client.NameClient = comboBox_nameClient.Text;
            client.Contact = textBox_Contact.Text;
            client.Phone = textBox_Phone.Text;
            client.Address = textBox_Address.Text;
            client.Email = textBox_Email.Text;
            return client;
        }*/
        public void loadComboBoxWithoutParam(ComboBox combo, string nameStoredProcedure, bool sort=true)//универсальный для любого списка без доп параметров: все категории, все инженеры, все типы ремонтов, все состояния...
        {
            if (!sort)
            {
                combo.DataSource = sql.getListString(nameStoredProcedure);
            }
            else
            {
                tmp = sql.getListString(nameStoredProcedure);

                tmp.Sort();

                combo.DataSource = tmp;
            }
        }

        public void loadComboBoxBrandsByCategory(ComboBox combo, string Category, bool sort = true)
        {
            if (!sort)
            {
                combo.DataSource = sql.getBrandsByCategory(Category);
            }
            else
            {
                tmp = sql.getBrandsByCategory(Category);

                tmp.Sort();

                combo.DataSource = tmp;
            }
        }

        public void loadComboBoxModelsByBrandsAndCategory(ComboBox combo, string Category, string Brand, bool sort = true)
        {
            if (!sort)
            {
                combo.DataSource = sql.getModelByCategoryAndBrand(Category, Brand);
            }
            else
            {
                tmp = sql.getModelByCategoryAndBrand(Category, Brand);

                tmp.Sort();

                combo.DataSource = tmp;
            }
        }
    }
}
