using System;

namespace huiswerk_enum_types
{
    class Program
    {
        #region enums
        //part 1
        enum Directions
        {
            North,
            South,
            East,
            West
        }
        #endregion

        static void Main(string[] args)
        {
            part3();

                void part3()
                {
                    //part 3
                    int ChosenDirection = 0;

                    Console.WriteLine("please enter the number of the direction you want to go");
                    Console.WriteLine("0-North, 1-South, 2-East , 3-West");
                    ChosenDirection = int.Parse(Console.ReadLine());

                    if (ChosenDirection < 0 | ChosenDirection > 3)
                    {
                        part3();
                    }
                    else
                    {
                        var playerDirection = (Directions)ChosenDirection;
                        Console.WriteLine((Directions)ChosenDirection);

                        Console.WriteLine("Press enter to continue...");

                        Console.ReadLine();

                        Console.Clear();

                        part2();
                    }

                    // part 2
                    void part2()
                    {
                        string DirectionChosen;

                        Console.WriteLine("which direction do you want to go?");
                        Console.WriteLine("North, South, East, West");

                        DirectionChosen = Console.ReadLine();

                        if (DirectionChosen == Directions.North.ToString())
                        {
                            Console.WriteLine("lets go to the north");
                        }
                        else if (DirectionChosen == Directions.South.ToString())
                        {
                            Console.WriteLine("lets go to the south");
                        }
                        else if (DirectionChosen == Directions.East.ToString())
                        {
                            Console.WriteLine("lets go to the east");
                        }
                        else if (DirectionChosen == Directions.West.ToString())
                        {
                            Console.WriteLine("lets go to the west");
                        }

                    }
                }

        }
    }
}
