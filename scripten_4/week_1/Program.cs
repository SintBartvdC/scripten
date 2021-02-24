using System;

namespace week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS 
            // lijst met objecten die een eigen nummer, nummer nemen we index


            // Array initieren
            int[] numberArray;
            numberArray = new int[3];

            // [10] [20] [30]
            //   0    1    2

            // Array vullen
            numberArray[0] = 10;
            numberArray[1] = 20;
            numberArray[2] = 30;

            Console.WriteLine(numberArray[1]);
            Console.WriteLine();

            // array direct vullen
            // kn je gebruiken als je weet wat er in je array komt
            string[] names = { "tinky winky", "dipsy", "laa-laa", "po" };
            Console.WriteLine(names[2]); // index nummer 2 is positie 3
            Console.WriteLine();

            string[] playerNames = new string[4]; // 0, 1, 2, 3

            Console.WriteLine("Please enter the player names");
            Console.WriteLine("Player 1 : ");
            playerNames[0] = Console.ReadLine();

            Console.WriteLine("Player 2 : ");
            playerNames[1] = Console.ReadLine();

            Console.WriteLine("Player 3 : ");
            playerNames[2] = Console.ReadLine();

            Console.WriteLine("Player 4 : ");
            playerNames[3] = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Playername for player 1 : " + playerNames[0]);
            Console.WriteLine("Playername for player 2 : {0}" + playerNames[1]);
            Console.WriteLine($"Playername for player 3 : {playerNames [2]}");
            Console.WriteLine($"Playername for player 4 : {playerNames [3]}");
            Console.WriteLine();

            // maak een string array met je 5 favorite shows op netflix
            // vraag de gebruiker om een getal tussen 1 t/m 5 in te voeren
            // print de titel van de bijbehorende show naar de console       
            
            string[] shows = new string[5];
            shows[0] = "Vikings";
            shows[1] = "The 100";
            shows[2] = "The walking dead";
            shows[3] = "The last kingdom";
            shows[4] = "Znation";
            Console.WriteLine("Kies een getal van 0 t/mn 4");
            string keuze = Console.ReadLine();
            int i = int.Parse(keuze);
            Console.WriteLine("je hebt {0} gekozen en dat is {1}", i, shows[i]);


            // manipuleren van arrays

            int[] numArray = {63, 44, 15, 76, 123};

            Console.Write(numArray[0] + ", ");
            Console.Write(numArray[1] + ", ");
            Console.Write(numArray[2] + ", ");
            Console.Write(numArray[3] + ", ");
            Console.Write(numArray[4]);
            Console.WriteLine();

            // sorteren
            Array.Sort(numArray);

            Console.Write(numArray[0] + ", ");
            Console.Write(numArray[1] + ", ");
            Console.Write(numArray[2] + ", ");
            Console.Write(numArray[3] + ", ");
            Console.Write(numArray[4]);
            Console.WriteLine();

            Array.Reverse(numArray);

            Console.Write(numArray[0] + ", ");
            Console.Write(numArray[1] + ", ");
            Console.Write(numArray[2] + ", ");
            Console.Write(numArray[3] + ", ");
            Console.Write(numArray[4]);
            Console.WriteLine();
            Console.WriteLine();

            // array lijst met 5 getallen
            // print 2 getallen naar de console

            int[] NumberArray;
            NumberArray = new int[5];

            NumberArray[0] = 1;
            NumberArray[1] = 2;
            NumberArray[2] = 3;
            NumberArray[3] = 4;
            NumberArray[4] = 5;

            Console.WriteLine(NumberArray[2]);
            Console.WriteLine(NumberArray[3]);
        }
    }
}
