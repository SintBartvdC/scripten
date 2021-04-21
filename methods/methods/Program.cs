using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. Create a method which accepts height and base (width) of a triangle as parameters,
            //     with that calculates and returns the area the triangle.
            //     The formula to calculate the area of a trinagle is:
            //     Area = 0.5 * (base * height)
            //     TIP : 0.5 can't be used with int so use the return type double

            float height;
            float width;

            Console.WriteLine("Can you give me a width value");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Can you give me a height value...");
            height = int.Parse(Console.ReadLine());

            Triangle(height, width);
            void Triangle(float width, float height)
            {
                var area = 0.5 * (width * height);
                Console.WriteLine("Your triangle = " + area);
            }

            Console.WriteLine();

            // 02. Rewrite the ArrowDamageCalculator in such a way that damage is also provided as a parameter

            Console.WriteLine("Enter distance");
            int distance1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter damage...");
            int damage1 = int.Parse(Console.ReadLine());

            ArrowDamageCalculator(distance1, damage1);

            int ArrowDamageCalculator(int distance, int damage)
            {

                if (distance > 50 && distance < 100)
                {
                    // damage = damage;
                }

                if (distance < 50)
                {
                    damage = damage * 2;
                }

                if (distance > 100)
                {
                    damage = damage / 2;
                }

                return damage;
            }

            // 03. Rewrite the ArrowDamageCalculator again implementing the following:
            //       - The method has the following parameters [pull] and [distance].
            //       - When [pull = 10] and [distance = 10], [damage = 50].
            //       - When [pull = 50] and [distance = 10], [damage = 250].
            //       - when [pull = 9000] and [distance = 1], [damage = 4500].
            //       - Do not use IF statements, but try to figure out the formula
            //         and use it in the method to calculate the damage.

            Console.WriteLine("Give me a pull value");
            int pull = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a distance value...");
            int distance2 = int.Parse(Console.ReadLine());

            ArrowDamageCalculator1(pull, distance2);
            int ArrowDamageCalculator1(int pull, int distance)
            {
                int damage;

                damage = pull / 2 * distance;

                Console.WriteLine();
                Console.WriteLine("Your damage = " + damage);

                return damage;
            }

            Console.WriteLine();

            // 04. Create a method called TargetHit() and add the following:
            //       - Input parameters are damage and distance.
            //       - The target is destroyed when damage > distance to the target.
            //       - Return True when the target is destroyed.
            //       - Return False when the target is destroyed.

            Console.WriteLine("Enter a damage value...");
            int damage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a distance value...");
            int distance = int.Parse(Console.ReadLine());

            TargetHit(damage, distance);
            int TargetHit(int damage, int distance)
            {
                int answer;

                answer = damage - distance;

                Console.WriteLine();

                if (damage > distance)
                {
                    Console.WriteLine("True, target destroyed.");
                }
                if (damage < distance)
                {
                    Console.WriteLine("False, target wasn't destroyed.");
                }

                return damage;
            }
        }
    }
}
