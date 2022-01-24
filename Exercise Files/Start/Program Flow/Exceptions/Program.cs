using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10000;
            int y = 10;
            int result;

            // TODO: try-catch expressions make error checking easier
            try{
                result = x / y;
                if (x > 1000){
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
                }
            Console.WriteLine("The result is: {0}", result);
            }
            catch (DivideByZeroException e){
                Console.WriteLine("Uh Oh!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e){
                Console.WriteLine("Sorry, 1000 is the limit");
                Console.WriteLine(e.Message);
            }
            finally{
                    Console.WriteLine("this code always runs");
            }

        }
    }
}
