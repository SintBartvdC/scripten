using System;

namespace SwitchCase
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Directions
        {
            North,
            East,
            South,
            West,
            Stay
        }
        static void Main(string[] args)
        {
            // part 1

            #region DaysOfTheWeek
            DateTime time = DateTime.Now;
            switch (time.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("And the day is " + WeekDays.Monday);
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("And the day is " + WeekDays.Tuesday);
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("And the day is " + WeekDays.Wednesday);
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("And the day is " + WeekDays.Thursday);
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("And the day is " + WeekDays.Friday);
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("And the day is " + WeekDays.Saturday);
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("And the day is " + WeekDays.Sunday);
                    break;
                default:
                    break;
            }
            #endregion
            
             part2();
            //part 2
            void part2()
            {
            #region
                Directions playerDirection; // dont mind this
                string answer;
                int number;
                Console.WriteLine("Choose a direction");
                Console.WriteLine("North, East, South , West,  (0, 1, 2, 3, 4) ");
                answer = Console.ReadLine();
                if (int.TryParse(answer, out number))
                {
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine(Directions.North);
                            break;
                        case 1:
                            Console.WriteLine(Directions.East);
                            break;
                        case 2:
                            Console.WriteLine(Directions.South);
                            break;
                        case 3:
                            Console.WriteLine(Directions.West);
                            break;
                        case 4:
                            Console.WriteLine(Directions.Stay);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("failed to do this");
                    part2();
                }
            }
            #endregion
        }
    }
}
