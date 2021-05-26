using System;

namespace _1._2_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            students bart = new students();

            bart.SetName("bart");

            bart.hobby = "rugby";

            bart.birth = "28-05-2003";

            bart.alive = "alive";

            Console.WriteLine("the students name is {0}", bart.GetName());

            Console.WriteLine("the student is born on {0}", bart.yearofbirth());

            Console.WriteLine("hobby is {1}", bart.GetName(), bart.hobby);

            Console.WriteLine("the student is {0}", bart.AliveOrNOt());


        }

    }

}