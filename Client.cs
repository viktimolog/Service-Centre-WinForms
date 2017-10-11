using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class Client : IComparable
    {
        private int idClient;
        private string nameClient;
        private string contact;
        private string phone;
        private string address;
        private string email;

        public int CompareTo(object o)
        {
            Client cl = o as Client;
            if (cl != null)
                return this.nameClient.CompareTo(cl.nameClient);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
        public Client() { }

        public Client(int idClient, string nameClient, string contact, string phone, string address, string email)
        {
            this.idClient = idClient;
            this.nameClient = nameClient;
            this.contact = contact;
            this.phone = phone;
            this.address = address;
            this.email = email;
        }

        public int IdClient { get { return idClient; } set { idClient = value; } }
        public string NameClient { get { return nameClient; } set { nameClient = value; } }
        public string Contact { get { return contact; } set { contact = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
