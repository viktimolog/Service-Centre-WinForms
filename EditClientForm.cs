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
    public partial class EditClientForm : Form
    {
        private Client client;
        private List<Client> clients;
        private SQLActions sql;

        public List<Client> Clients { get { return clients; } }
        public EditClientForm(Client client = null)
        {
            InitializeComponent();
            this.client = client;
            clients = new List<Client>();
            sql = new SQLActions();
        }

        public void textsforTextboxes(Client client)
        {
            textBox_Contact.Text = client.Contact;
            textBox_Phone.Text = client.Phone;
            textBox_Address.Text = client.Address;
            textBox_Email.Text = client.Email;
            textBox_NewNameClient.Text = comboBox_nameClient.Text;
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            comboBox_nameClient.DataSource = sql.getClients();
            comboBox_nameClient.DisplayMember = "nameClient";
            comboBox_nameClient.ValueMember = "nameClient";

            if (client != null) comboBox_nameClient.Text = client.NameClient;
            else comboBox_nameClient.SelectedIndex = 0;

            textsforTextboxes((Client)comboBox_nameClient.SelectedItem);
        }

        private void comboBox_NameClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            textsforTextboxes((Client)comboBox_nameClient.SelectedItem);
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                client.NameClient = textBox_NewNameClient.Text;
                client.Contact = textBox_Contact.Text;
                client.Phone = textBox_Phone.Text;
                client.Address = textBox_Address.Text;
                client.Email = textBox_Email.Text;
                (new SQLActions()).EditClient(comboBox_nameClient.Text, textBox_NewNameClient.Text, textBox_Contact.Text, textBox_Phone.Text, textBox_Address.Text, textBox_Email.Text);
                MessageBox.Show("Данные клиента успешно изменены!");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }
    }
}
