using System;

namespace PrimeB
{
    class TwoWheeler
    {
        private int reg;
        private string name;
        private string model;
        //properties

        public int Reg
        {
            get { return reg; }
            set { reg = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; } 
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
    //second class that will inherit twowheeler

    class Bike : TwoWheeler
    {
        private string speed;
        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }

    class Ebike : Bike
    {
        private string range;
        public string Range
        {
            get { return range; }
            set { range = value; }
        }
    }


}
