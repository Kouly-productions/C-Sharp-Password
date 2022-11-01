using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Classes
{
    public class Football
    {
        public void Calculate()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Write number of ");

            //This will call the method from the other class (Football)
            var Football = new Ball();
            Football.GetInput();
        }
    }
    public static class ConsoleHelper
    {
        public static void WriteLine(string s) => Console.WriteLine(s);

        public static string ReadLine() => Console.ReadLine();

    }
}