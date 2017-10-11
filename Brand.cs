using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class Brand
    {
        private int idCategory;
        private int idBrand;
        private string nameBrand;
        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public int IdBrand
        {
            get { return idBrand; }
            set { idBrand = value; }
        }

        public string NameBrand
        {
            get { return nameBrand; }
            set { nameBrand = value; }
        }
    }
}
