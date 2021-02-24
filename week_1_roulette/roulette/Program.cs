using System;

namespace roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            // russisch roulette
            // istoool met 6 kamers
            // 1 kamer is maar gevuld
            // vullen is random

            Random rnd = new Random();
            bool[] revolver = new bool[6];

            revolver[0] = false;
            revolver[1] = false;
            revolver[2] = false;
            revolver[3] = false;
            revolver[4] = false;
            revolver[5] = false;

            // bool[] revolver = {"false", "false", "false", "false", "false"};

            loadBullet();

            Console.WriteLine("heeft kamer 1 een kogel? : " + revolver[0]);
            Console.WriteLine("heeft kamer 2 een kogel? : " + revolver[1]);
            Console.WriteLine("heeft kamer 3 een kogel? : " + revolver[2]);
            Console.WriteLine("heeft kamer 4 een kogel? : " + revolver[3]);
            Console.WriteLine("heeft kamer 5 een kogel? : " + revolver[4]);
            Console.WriteLine("heeft kamer 6 een kogel? : " + revolver[5]);

            void loadBullet()
            {
                int bullet = rnd.Next(0, 6);
                revolver[bullet] = true;
            }


        }
    }
}
