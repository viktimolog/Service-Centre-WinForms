using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class Model
    {
        private int idModel;
        private string nameModel;
        private int idBrand;
        private int idCategory;   
        public int IdCategory {get { return idCategory; }set { idCategory = value; }}
        public int IdBrand{get { return idBrand; }set { idBrand = value; }}
        public int IdModel { get { return idModel; } set { idModel = value; } }
        public string NameModel { get { return nameModel; } set { nameModel = value; } }

    }
}
