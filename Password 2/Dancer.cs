using Logic_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dancer
{
    class Dance
    {
        public static void Dancing ()
        {

            var Class1 = new DancerLogic();
            int danser1p;
            string danser1;
            int danser2p;
            string danser2;
            int pointtotal;

            Console.WriteLine("Who is the first dancer");
            danser1 = Console.ReadLine();
            Console.WriteLine("How many points does " + danser1 + "get");
            danser1p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(danser1 + " got " + danser1p);
            Console.Clear();

            Console.WriteLine("Who is the second dancer");
            danser2 = Console.ReadLine();
            Console.WriteLine("How many points did " + danser2 + "get");
            danser2p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(danser2 + " got " + danser2p);
            Console.Clear();


            pointtotal = (DancerLogic.GetInput(danser1p,danser2p));
            Console.WriteLine(danser1 + " and " + danser2 + " has "+ pointtotal + " points total");

            Console.ReadKey();
        }
    }
}
