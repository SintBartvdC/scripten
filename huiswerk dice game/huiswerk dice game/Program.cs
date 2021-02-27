using System;

namespace huiswerk_dice_game
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
            PlayerNames();
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

            void PlayerNames()
            {
                Console.WriteLine("Player one what is your name?");
                playerOneName = Console.ReadLine();

                Console.WriteLine("Player two what is your name?");
                playerTwoName = Console.ReadLine();

                Console.WriteLine("Player three what is your name?");
                playerThreeName = Console.ReadLine();

                Console.WriteLine("Player four what is your name?");
                playerFourName = Console.ReadLine();
            }

            int D50Roll()
            {
                return rnd.Next(1, 51);
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
