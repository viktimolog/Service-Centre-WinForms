using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class TypeRepair
    {
        private int idType;
        private string nameType;
        public int IdType { get { return idType; } set { idType = value; } }
        public string NameType { get { return nameType; } set { nameType = value; } }
    }
}
