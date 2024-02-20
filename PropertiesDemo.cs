using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Program
{
    class Rectangle
    {

        //properties is used to initialize instance variable
        // and return value of instance variable
        //it is same like getter and setter method
        //set is used to initialize instance variable and 
        //get is used to return value of instance variable
        private int lenght;
        private int breadht;
        //using properties
        public int Length
        {
            get { return lenght; }
            set { this.lenght = value; }
        }

        public int Breadht{
            get{ return breadht;}
            set{this.breadht = value; }
        }
    }
}
