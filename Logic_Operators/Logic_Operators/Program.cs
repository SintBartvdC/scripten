using System;

namespace Logic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AND operator
            // 01. Note down the symbol of the AND operator.
            // &&

            // 02. Explain what an AND operator is and what it does.
            // when comparing booleans both conditions need to be true 

            // 03. Finish the Truth table for the AND operator.
            //     A     | B     | C
            //     true  | true  | true
            //     true  | false | false
            //     false | true  | false
            //     false | false | false

            #endregion

            #region OR operator
            // 04. Note down the symbol of the OR operator.
            // ||

            // 05. Explain what an OR operator is and what it does.
            //  when comparing booleans at least one of the conditions need to be true

            // 06. Finish the Truth table for the OR operator.
            //     A     | B     | C
            //     true  | true  | true
            //     true  | false | true
            //     false | true  | true
            //     false | false | false

            #endregion

            #region NOT operator
            // 07. Note down the symbol of the NOT operator.
            // !

            // 08. Explain what an NOT operator is and what it does.
            // when placing this before a condition it inverts the value

            #endregion

            #region Truth table coding
            // 09.
            // Write code that satisfies the following Truth tables
            // For the given values of A and B you need to write code that
            // calculates the correct value for C

            // You may write the code however you like.
            // Just IF statements might do the trick but... 
            // Try to use them in combination with logical operators and write clean readable code.
            bool c;
            bool a = true;
            bool b = true;
            //   a.  A     | B     | C
            //      -------|-------|------
            //       true  | true  | false
            //       true  | false | true
            //       false | true  | false
            //       false | false | true

            A(a, b);

            bool A(bool a, bool b)
            {
                c = !b;

                return c;
            }
            Console.WriteLine("c is " + c);


            Console.WriteLine();
            //   b.  A     | B     | C
            //      -------|-------|------
            //       true  | true  | true
            //       true  | false | true
            //       false | true  | false
            //       false | false | true
            B(a, b);

            bool B(bool a, bool b)
            {
                c = true;

                if (a==false && b==true)
                {
                    c = false;
                }

                return c;
            }

            Console.WriteLine("c is " + c);



            Console.WriteLine();
            //   c.  A     | B     | C
            //      -------|-------|------
            //       true  | true  | true
            //       true  | false | true
            //       false | true  | true
            //       false | false | true
            C(a, b);

            bool C(bool a, bool b)
            {
                c = true;

                return c;
            }

            Console.WriteLine("c is " + c);


            #endregion

            #region Weird car
            // 10.
            // A car has 3 booleans, 'hasFuel', 'hasElectricity' and 'canDrive'.
            // the car can only drive when it has either fuel OR electricity.
            // It can not drive on both.
            // It is a weird car...
            // Write code which assigns the correct value to 'canDrive' depending on the available fuel.

            Boolean hasFuel;
            Boolean hasElectricity;
            Boolean canDrive;
            
            #endregion
        }
    }
}
