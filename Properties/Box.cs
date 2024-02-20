using System;
using System.ComponentModel;

namespace First_Program.Properties
{
    class Box
    {
        //Instance variable : class data
        private int lenght;
        private int breadht;
        private int height;

        //constuctor used to intialize instance variable
        //default constructor without parameter
        public Box()
        {
            lenght = 0;
            breadht = 0;
            height = 0;
        }    
        //parameterized constructor : takes data

        public Box(int lenght, int breadht,int height)
        {
            this.lenght = lenght;
            this.breadht = breadht; 
            this.height = height;

        }
        //method : used to provide some services
        //method without returing value
        public void calArea()
        {
            int area = this.lenght*this.breadht*this.height;
            Console.WriteLine("area is "+ area);
        }
    }

}
