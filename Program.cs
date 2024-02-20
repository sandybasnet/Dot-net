using First_Program.Properties;
using PrimeB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace First_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating ojbect of box
            //when obejct is created constructor is called 
            /*Box b1 = new Box(); //defalut constructor
            b1.calArea();
            Box b2 = new Box(10,20,30);
            b2.calArea();
            Console.WriteLine("---example on properties---");
            Rectangle r1 = new Rectangle();
            //calling set of lenght and breadht
            r1.Length = 10;//calls set of lenght
            r1.Breadht = 10;//calls set of breadht
            //calling get of lenght and breadht
            Console.WriteLine("lenght is "+ r1.Length);
            Console.WriteLine("breadht is " +  r1.Breadht);
            int area = r1.Length * r1.Breadht;
            Console.WriteLine("area is " + area);
            Console.ReadKey();*/

            Console.WriteLine("----Multi Level Inheritance----");
            //creating obj of grandchild(Electric bike)
            Ebike eb = new Ebike();
            //using grand parent(twowheelers)
            eb.Reg = 12;
            eb.Name = "noiu";
            eb.Model = "new";

            //using parent property(Bike)

            eb.Speed = "40";

            //using own property

            eb.Range = "50";
            Console.WriteLine("reg is "+ eb.Reg);
            Console.WriteLine("name is "+ eb.Name);
            Console.WriteLine("model is"+ eb.Model);
            Console.WriteLine("speed is "+ eb.Speed);
            Console.WriteLine("range is "+eb.Range); 

            //creating obj of Bike
            Bike bi = new Bike
            {
                //using twowheeler property

                Reg = 123,
                Name = "Home",
                Model = "old",
                Speed = "70" //own property
            };
            //bi.Range = "40"; //cannot be accessed since it is child property           
            Console.WriteLine("-----------");
            Console.WriteLine("reg is " + bi.Reg);
            Console.WriteLine("name is " + bi.Name);
            Console.WriteLine("model is" + bi.Model);
            Console.WriteLine("speed is " + bi.Speed);

            Console.WriteLine("");
            Console.WriteLine("---example on base keyword---");
            Solution s1 = new Solution();
            Solution s2 = new Solution(10,20,30);
            s1.sum();
            s2.square();

            Console.ReadKey();
        }
    }
}
