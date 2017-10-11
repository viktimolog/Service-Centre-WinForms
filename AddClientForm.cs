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
{   public partial class AddClientForm : Form
    {
        private Client newClient;
        public AddClientForm(Client newClient)
        {
            InitializeComponent();
            this.newClient = newClient;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            newClient.NameClient = textBox_nameClient.Text;
            newClient.Contact = textBox_Contact.Text;
            newClient.Phone = textBox_Phone.Text;
            newClient.Address = textBox_Address.Text;
            newClient.Email = textBox_Email.Text;
            try
            {
                (new SQLActions()).AddClient(textBox_nameClient.Text, textBox_Contact.Text, textBox_Phone.Text, textBox_Address.Text, textBox_Email.Text);
                MessageBox.Show("Новый клиент: " + textBox_nameClient.Text + " успешно добавлен!", "Успешное добавление клиента");
            }
            catch
            {
                MessageBox.Show("Not connected to DB", "Error");
            }
            this.Close();
        }
    }
}
