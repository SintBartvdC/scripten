using System;

namespace week_2._1ArrayOefenen
{
    class Program
    {
        static void Main(string[] args)
        {
            // opdracht 1
            // maak een lege int array van 5 waarden, vul dezen handmatig per index
            // print de 2e waarde naar de console
            int[] numberArray;
            numberArray = new int[5];

            numberArray[0] = 1;
            numberArray[1] = 2;
            numberArray[2] = 3;
            numberArray[2] = 4;
            numberArray[2] = 5;

            Console.WriteLine("second array value: " + numberArray[1]);
            Console.WriteLine();
            // opdracht 2
            // maak een gevulde int array met 7 getallen en print de 5e waarde naar de console

            string[] getallen = { "1", "2", "3", "4", "5", "6", "7" };
            Console.WriteLine(getallen[4]);
            Console.WriteLine();

            // opdracht 3
            // maak een logo string array met 3 posities en vul deze met user input d.n.v. een loop
            // print de waarde van de array naar de console d.m.v. een foreach loop

            string[] input = new string[3];

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("give some input please:");
                input[i] = Console.ReadLine();
            }
            Console.WriteLine();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // opdracht 4 
            // maak een logo int array met 10 posities en vul deze m.b.v. een random en een loop
            // met random getallen sorteer de array daarna en print de waarde naar de console

            Random rnd = new Random();
            int[] randomNumber = new int[10];

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = rnd.Next(0, 3466);
            }

            foreach (var number in randomNumber)
            {
                Console.Write(number + ", ");
            }
        }
    }
}
