using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCentre
{
    public class Device
    {
        private string category;
        private string brand;
        private string model;

        public string Category { get { return category; } set { category = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get { return model; } set { model = value; } }
    }
}
