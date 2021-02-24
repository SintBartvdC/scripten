using System;

namespace week2._3_reload
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            bool[] nerfCylinder = new bool[6];
            bool isFullyLoaded = false;
            #endregion

            #region code
            // let's start with emptying the cylinder
            for (int i = 0; i < nerfCylinder.Length; i++)
            {
                nerfCylinder[i] = false;
            }

            // let's check if the nerf is empty
            CheckCylinder();

            Console.WriteLine();

            // let's reload
            Reload();

            Console.WriteLine();

            // let's check again
            CheckCylinder();

            Console.WriteLine();

            ContinueAndClear();

            Console.WriteLine("i shot some darts... let'schck which chambers are empty now");
            nerfCylinder[2] = false;
            nerfCylinder[4] = false;

            CheckCylinder();
            Reload();
            #endregion

            #region methods
            void CheckCylinder()
            {
                // loop over the chambers to check for darts
                for (int i = 0; i < nerfCylinder.Length; i++)
                {
                    if (nerfCylinder[i] == false)
                    {
                        Console.WriteLine($"chamber {i + 1} is empty");
                        isFullyLoaded = false;
                    }
                    else
                    {
                        Console.WriteLine($"chamber {i+1} contains a dart");
                    }
                }
                if (isFullyLoaded == true)
                {
                    Console.WriteLine("the cylinder is fully loaded with darts");
                }
                else
                {
                    Console.WriteLine("you're missing some darts... maybe reload");
                }
            }

            void Reload()
            {
                for (int i = 0; i < nerfCylinder.Length; i++)
                {
                    if (nerfCylinder[i] == false)
                    {
                        nerfCylinder[i] = true;
                        Console.WriteLine($"you put a dart in chamber {i + 1}");

                    }
                }
                isFullyLoaded = true;
            }

            void ContinueAndClear()
            {
                Console.WriteLine();
                Console.WriteLine("press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            #endregion
        }
    }
}
