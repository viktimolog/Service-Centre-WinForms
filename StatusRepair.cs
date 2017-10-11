using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class StatusRepair
    {
        private int idStatus;
        private string nameStatus;
        public int IdRepair { get { return idStatus; } set { idStatus = value; } }
        public string NameStatus { get { return nameStatus; } set { nameStatus = value; } }
    }
}
