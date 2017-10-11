using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class Repair
    {
        private int idRepair;
        private DateTime date;
        private int idClient;
        private int idModel;
        private string sn;
        private int idType;
        private string defect;
        private string kitView;
        private int idEngineer;
        private string result;
        private int price;
        private int idStatus;

        public Repair() { }

        public Repair(int idRepair, DateTime date, int idClient, int idModel, string sn, int idType, string defect, string kitView, int idEngineer
            ,string result, int price, int idStatus)
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
        }

        public int IdRepair { get { return idRepair; } set { idRepair = value; } }
        public int IdClient { get { return idClient; } set { idClient = value; } }
        public int IdModel { get { return idModel; } set { idModel = value; } }
        public int IdType { get { return idType; } set { idType = value; } }
        public int IdEngineer { get { return idEngineer; } set { idEngineer = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int IdStatus { get { return idStatus; } set { idStatus = value; } }

        public DateTime Date { get { return date; } set { date = value; } }

        public string SN { get { return sn; } set { sn = value; } }
        public string Defect { get { return defect; } set { defect = value; } }
        public string KitView { get { return kitView; } set { kitView = value; } }
        public string Result { get { return result; } set { result = value; } }


    }
}
