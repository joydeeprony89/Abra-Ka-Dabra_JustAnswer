using System;

namespace Abra_Ka_Dabra_JustAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number!");
                int input;
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input , Enter only number");
                    Console.WriteLine("Please enter a number!");
                }

                if (input < 1)
                {
                    Console.WriteLine("Value can not be less than 1");
                }
                else if (input > 64)
                {
                    Console.WriteLine("Can not calculate the product of Abra ka dabraseries greater than 64");
                }
                else
                {
                    var output = AbraKaDabraSeries(input);
                    Console.WriteLine("Product of first {0} abra ka dabra series is {1}", input, output);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPS, Expection Occured :( {0}", ex.Message);
            }
        }

        /// <summary>
        /// Calculate the product of first ‘n’ terms of abra_ka_dabra series.
        /// </summary>
        /// <param name="input">no of abra ka dabra series prouct</param>
        /// <returns>result</returns>
        static ulong AbraKaDabraSeries(int input)
        {
            // (1+2+3), (2+3+4), (3+4+5), (4+5+6), (5+6+7), (6+7+8), (7+8+9)  …  
            ulong new1 = 1, new2 = 2, new3 = 3, prevmul = 1, newMul = 1;
            try
            {
                for (int i = 1; i <= input; i++)
                {
                    ulong newSum = new1 + new2 + new3;
                    new1 = new2;
                    new2 = new3;
                    new3 = new2 + 1;
                    newMul = newSum * prevmul;
                    prevmul = newMul;
                }
                return newMul;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
