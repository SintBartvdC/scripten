using System;

namespace huiswerk_week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Maak een toolje wat...
             * - de gebruiker vraagt om het te starten
             * - een lijst met minimaal 3 voorwerpen, karakters, shows of iets dergelijks doorloopt
             * - per optie de gebruiker vraagt of deze dit leuk vind ja of nee 
             *   protip: antwoorden kun je opslaan in een nieuwe array
             * - per vraag een random antwoord geeft (keuze uit minimaal 6)
             * - na alle opties gehad te hebben de leuk gevonden opties laat zien
             *   en een mening over de keuze geeft (keuze uit minimaal 6) 
             *
             * Zorg voor voldoende informatie naar de gebruiker
             * wees creatief, schrijf je eigen code en maak er iets leuks van.
             */

            /*
             * Tips
             * - Gebruik arrys.
             * - Met loops en ifjes kom je een heel eind...
             * - Als je door een array loopt met een loop kun je de index
             *   gebruiken om dezelfde locatie in een andere array te vullen.
             *   Of om informatie op dezelfde positie in een andere array op te halen.
             * - Bij de vraag of de gebruiker iets leuk vind of niet kun je foute invoer 
             *   gewoon als een ja of nee interpreteren. 
             */

            #region app
            Random rnd = new Random();
            string[] series = { "The 100", "Vikings", "The walking dead" };
            string[] responses = new string[6];
            string[] reviews = new string[8];

            string user;
            string userInput;
            bool[] userLikes = new bool[series.Length];

            responses[0] = "Nice...";
            responses[1] = "HAHAHAHA...";
            responses[2] = "Boring...";
            responses[3] = "Ok...";
            responses[4] = "Good one...";
            responses[5] = "interesting...";

            reviews[0] = "Lorem ipsum dolor.";
            reviews[1] = "What? No way...";
            reviews[2] = "axe axe axe... dead";
            reviews[3] = "djasjdcajknsc..dcajksndjca!";
            reviews[4] = "Whoever this is, leave me alone!";
            reviews[5] = "There are many moons but only one is ours.";
            reviews[6] = "It sucks...";
            reviews[7] = "I love it, please give me more...";

            Console.WriteLine("What is your name? : ");
            userInput = Console.ReadLine();
            user = userInput;

            for (int i = 0; i < series.Length; i++)
            {
                Console.Write($"Do you like {series[i]}? [y/n]: ");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    userLikes[i] = true;
                    Console.WriteLine(RandomResponse());
                }
                else if (userInput == "n")
                {
                    userLikes[i] = false;
                    Console.WriteLine(RandomResponse());
                }
                else
                {
                    userLikes[i] = false;
                    Console.WriteLine("Ok... I'll take that as a no...");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < userLikes.Length; i++)
            {
                if (userLikes[i] == true)
                {
                    Console.WriteLine($"{user}, you like {series[i]}... we say this about {series[i]} : ");
                    Console.WriteLine("\"" + RandomReview() + "\"");
                    Console.WriteLine();
                }
            }

            string RandomResponse()
            {
                return responses[rnd.Next(0, responses.Length)];
            }

            string RandomReview()
            {
                return reviews[rnd.Next(0, reviews.Length)];
            }

            #endregion

        }
    }
}
