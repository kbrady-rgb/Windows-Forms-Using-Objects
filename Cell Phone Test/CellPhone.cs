using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cell_Phone_Test
{
    class CellPhone
    {
        //Fields
        private string _brand; //phone brand
        private string _model; //phone model
        private decimal _price; //retail price

        //Constructor
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        //Brand property
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        //Model property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //Price property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
