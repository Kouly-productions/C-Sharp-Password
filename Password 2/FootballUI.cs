using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Classes;

namespace Password_2
{
    internal class FootballUI
    {
        public void something()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Skriv antal afleveringer");

            //This will call the method from the other class (Football)
            var Football = new Ball();
            Football.GetInput();
        }
    }
}