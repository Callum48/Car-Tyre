using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Tyre_Program
{
    class Tyre
    {
        private string tireType = "T100";
        private int price = 36;
        private int stock = 10;

        public string TireType
        {
            get { return tireType; }
            set { tireType = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }


    }
}
