using System;

namespace toets_dice_game
{
    class Program
        {
        static void Main(string[] args)
        {
            #region variables
            Random rnd = new Random();

            string playerOneName;
            string playerTwoName;
            string playerThreeName;
            string playerFourName;

            int playerOneDiceRoll1;
            int playerTwoDiceRoll1;
            int playerThreeDiceRoll1;
            int playerFourDiceRoll1;

            int playerOneDiceRoll2;
            int playerTwoDiceRoll2;
            int playerThreeDiceRoll2;
            int playerFourDiceRoll2;

            int playerOneDiceRollTotal;
            int playerTwoDiceRollTotal;
            int playerThreeDiceRollTotal;
            int playerFourDiceRollTotal;
            #endregion

            #region code
            Console.WriteLine("you can only play this game with four players");
            askplayers();
            Game();
            #endregion

            #region methods
            void Game()
            {
                RollDice();
                ShowResults();
                continueandclear();
                askContinuePlay();
            }

            int D50Roll()
            {
                return rnd.Next(1, 51);
            }

            void askplayers()
            {
                Console.WriteLine("with how many players do you play?");
                string[] players = { "1", "2", "3", "4" };
                for (int i = 0; i < players.Length; i++)
                {
                    Console.WriteLine("enter your name here:");
                    players[i] = Console.ReadLine();
                }
                Console.WriteLine();

                foreach (var item in players)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

            }


            void RollDice()
            {
                playerOneDiceRoll1 = D50Roll();
                playerOneDiceRoll2 = D50Roll();
                playerOneDiceRollTotal = playerOneDiceRoll1 + playerOneDiceRoll2;

                playerTwoDiceRoll1 = D50Roll();
                playerTwoDiceRoll2 = D50Roll();
                playerTwoDiceRollTotal = playerTwoDiceRoll1 + playerTwoDiceRoll2;

                playerThreeDiceRoll1 = D50Roll();
                playerThreeDiceRoll2 = D50Roll();
                playerThreeDiceRollTotal = playerThreeDiceRoll1 + playerThreeDiceRoll2;

                playerFourDiceRoll1 = D50Roll();
                playerFourDiceRoll2 = D50Roll();
                playerFourDiceRollTotal = playerFourDiceRoll1 + playerFourDiceRoll2;
            }

            void ShowResults()
            {
                Console.WriteLine($"player {playerOneName} rolled {playerOneDiceRoll1} and {playerOneDiceRoll2} that is an total of {playerOneDiceRollTotal}");

                Console.WriteLine($"player {playerTwoName} rolled {playerTwoDiceRoll1} and {playerTwoDiceRoll2} that is an total of {playerTwoDiceRollTotal}");

                Console.WriteLine($"player {playerThreeName} rolled {playerThreeDiceRoll1} and {playerThreeDiceRoll2} that is an total of {playerThreeDiceRollTotal}");

                Console.WriteLine($"player {playerFourName} rolled {playerFourDiceRoll1} and {playerFourDiceRoll2} that is an total of {playerFourDiceRollTotal}");
            }

            void continueandclear()
            {
                Console.WriteLine("Press [enter] to continue...");
                Console.ReadLine();
                Console.Clear();
            }

            void askContinuePlay()
            {
                string userinput;

                Console.WriteLine("do you want to play another round? [y/n]");
                userinput = Console.ReadLine();

                continuePlay(userinput.ToLower());
            }

            bool continuePlay(string input)
            {
                bool cont = false;
                if (input == "y")
                {
                    cont = true;
                    Game();
                }
                else if (input == "n")
                {
                    cont = false;
                }
                else
                {
                    askContinuePlay();
                }
                return cont;
            }
            #endregion
        }
    }
}