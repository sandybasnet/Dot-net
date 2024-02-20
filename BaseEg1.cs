using System;
using System.Data.SqlTypes;
//constructor of superclass cannot be called directly by object of subclass.
//to call constructor of superclass , base keyword should be used.
//Base Keyword uses:
//1.To call the superclass constructor
//2.To call overridden method(method overriding)
namespace PrimeB
{
    class Calculation
    {
        private int x;
        private int y;
        //constructor
        public Calculation() 
        {
            Console.WriteLine("Default Cons of parent class");
        }
        public Calculation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void sum()
        {
                Console.WriteLine("sum is "+ (x+y));
        }
    }

    class Solution : Calculation
    {
        private int z;
        public Solution() : base()//calls default constructor of superclass
        {
            Console.WriteLine("Default cons of Solution");
        }

        public Solution(int z,int x, int y ):base()
        {
            this.z = z;
        }

        public void square()
        {
            Console.WriteLine("sq is" + (z * z));
        }
    }
}
