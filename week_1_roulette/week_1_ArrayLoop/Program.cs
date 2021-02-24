using System;

namespace week_1_ArrayLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Lambo", ""};
            cars[4] = "Tesla";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
                Console.WriteLine();

                for (int j = 0; j < cars.Length; j++)
                {
                    Console.WriteLine(cars[j]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);

                if (i == 2)
                {
                    break;
                }
            }

            Console.WriteLine("\n-----------------\n");

            Array.Reverse(cars);

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
