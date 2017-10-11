using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class Category
    {
        private int idCategory;
        private string nameCategory;
        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public string NameCategory
        {
            get { return nameCategory; }
            set { nameCategory = value; }
        }
    }
}
