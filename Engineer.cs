using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class Engineer
    {
        private int idEngineer;
        private string nameEngineer;        
        public int IdEngineer { get { return idEngineer; } set { idEngineer = value; } }
        public string NameEngineer { get { return nameEngineer; } set { nameEngineer = value; } }
    }
}
