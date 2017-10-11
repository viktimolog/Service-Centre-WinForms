using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
  public class RepairView
    {
        private int idRepair;//+
        private DateTime date;//+


        private string nameClient;//+
        private string contact;//+
        private string phone;//+
        private string device;//+

        private string sn;//+

        private string typeRepair;//+

        private string defect;//+
        private string kitView;//+

        private string engineer;//+

        private string result;//+
        private int price;//+

        private string status;//+

        public RepairView() { }

      /*  public Repair(int idRepair, DateTime date, int idClient, int idModel, string sn, int idType, string defect, string kitView, int idEngineer
            , string result, int price, int idStatus)
        {
            this.idRepair = idRepair;
            this.date = date;
            this.idClient = idClient;//2
            this.IdModel = IdModel;//3
            this.sn = sn;
            this.idType = idType;//5
            this.defect = defect;
            this.kitView = kitView;//7
            this.idEngineer = idEngineer;
            this.result = result;
            this.price = price;
            this.idStatus = idStatus;
        }*/

        public int IdRepair { get { return idRepair; } set { idRepair = value; } }
        public int Price { get { return price; } set { price = value; } }

        public DateTime Date { get { return date; } set { date = value; } }

        public string SN { get { return sn; } set { sn = value; } }
        public string Defect { get { return defect; } set { defect = value; } }
        public string KitView { get { return kitView; } set { kitView = value; } }
        public string Result { get { return result; } set { result = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Engineer { get { return engineer; } set { engineer = value; } }
        public string TypeRepair { get { return typeRepair; } set { typeRepair = value; } }
        public string Device { get { return device; } set { device = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Contact { get { return contact; } set { contact = value; } }
        public string NameClient { get { return nameClient; } set { nameClient = value; } }
    }
}
