using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetAns10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };
            try
            {

                for (int j = 0; j < number.Length; j++)
                {



                    try
                    {

                        Console.WriteLine("Number: " + number[j] +
                                          "\nDivisor: " + divisor[j] +
                                          "\nQuotient: " + number[j] / divisor[j]);
                    }


                    catch (DivideByZeroException ex)
                    {

                        Console.WriteLine("Inner Try Catch Block"+ ex.Message);
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Outer Try Catch Block"+ex.Message);
            }
            Console.ReadLine();
        }
    }

}