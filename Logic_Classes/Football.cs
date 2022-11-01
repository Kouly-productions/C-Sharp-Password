using System;

namespace Logic_Classes
{
   public class Ball
    {
        public string Ten()
        {
            return "High Five - Juble!!!";
        }

        public string One()
        {
            return "Shh";
        }


        public string Huh()
        {
            return "Huh!";
        }

        public string Mid()
        {
            return "";
        }

        public string Mål()
        {
            return "Olé Olé Olé";
        }

        public void GetInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Ten();
            One();
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice > 9)
            {
                Console.Clear();
                for (int i = 0; i < choice; i++)
                {
                    Console.WriteLine(Huh());
                }
                Console.WriteLine(Ten());
            }
            else if (choice < 1)
            {
                int i;
                Console.Clear();
                for (i = 0; i < choice; i++)
                {
                    Console.WriteLine(Huh());
                }
                Console.WriteLine(One() + i);
            }
            else if (choice > 0 && choice < 10)
            {
                Console.Clear();
                for (int i = 0; i < choice; i++)
                {
                    Console.WriteLine(Huh());
                }
                Console.WriteLine(Mid());
            }

            Console.WriteLine("Did your team score? write (Y) for yes (N) for no");

            string malT = Console.ReadLine().ToUpper();
            if (malT == "Y")
            {
                Console.Clear();
                Console.WriteLine(Mål());
                Console.ReadKey();
            }
            else if (malT == "N")
            {
                Console.Clear();
                Console.WriteLine("oh, too bad :(");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: you din't write (Y) or (N)");
                Console.ReadKey();
            }
        }
    }
}