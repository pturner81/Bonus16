using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Cars
    {
        //Fields
        private string make;
        private string model;
        private int year;
        private double price;

        //Properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        //default constructor
        public Cars()
        {
            Make = "unassigned";
            Model = "unassigned";
            Year = 2000;
            Price= 0;
        }
        //override constructor
        public Cars(string ma, string mo, int ye, double pr)
        {
            Make = ma;
            Model = mo;
            Year = ye;
            Price = pr;
        }
        //methods

    }
}
