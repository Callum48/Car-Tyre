using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Tyre_Program
{
    class Fitting
    {
        private string carRegistration;
        private int numOfTyres;
        private string fittingDate;

        public string CarRegistration
        {
            get { return carRegistration; }
            set { carRegistration = value; }
        }

        public int NumOfTyres
        {
            get { return numOfTyres; }
            set { numOfTyres = value; }
        }

        public string FittingDate
        {
            get { return fittingDate; }
            set { fittingDate = value; }
        }


    }
}
