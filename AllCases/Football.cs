using System;

namespace Football
{
    class Ball
    {
        public int Afleveringer;
        public string Mål;

        public string ten()
        {
            return "High Five - Juble!!!";
        }

        public string one()
        {
            return "Shh";
        }


        public string huh()
        {
            return "Huh!";
        }

        public string mid()
        {
            return "";
        }

        public string mål()
        {
            return ("Olé Olé Olé");
        }

        public void GetInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            ten();
            one();
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice > 9)
            {
                Console.Clear();
                for (int i = 0; i < choice; i++)
                {
                    Console.WriteLine(huh());
                }
                Console.WriteLine(ten());
            }
            else if (choice < 1)
            {
                int i;
                Console.Clear();
                for (i = 0; i < choice; i++)
                {
                    Console.WriteLine(huh());
                }
                Console.WriteLine(one() + i);
            }
            else if (choice > 0 && choice < 10)
            {
                Console.Clear();
                for (int i = 0; i < choice; i++)
                {
                    Console.WriteLine(huh());
                }
                Console.WriteLine(mid());
            }

            Console.WriteLine("har dit hold skoret mål? skriv (Y) for ja (N) for nej");

            string malT = Console.ReadLine().ToUpper();
            if (malT == "Y")
            {
                Console.Clear();
                Console.WriteLine(mål());
                Console.ReadKey();
            }
            else if (malT == "N")
            {
                Console.Clear();
                Console.WriteLine("oh :(");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: du skrev ikke (Y) eller (N)");
                Console.ReadKey();
            }
        }
    }
}