using System;

namespace CheckPerfectNumber
{
    class Program
    {
        private static void CheckPerfectNumber()
        {

            int NumberNeedCheck;
            int SumCommomDivisors = 0;
            int i;

            Console.Write("Enter number to need check perfect number: ");
            NumberNeedCheck = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Commom divisors of {0} are: ", NumberNeedCheck);
            for ( i = 1; i < NumberNeedCheck; i++)
            {

                if ( NumberNeedCheck % i == 0)
                {

                    SumCommomDivisors = SumCommomDivisors + i;
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine(NumberNeedCheck);

            if ( SumCommomDivisors == NumberNeedCheck)
            {
                Console.WriteLine("{0} is a perfect number", NumberNeedCheck);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", NumberNeedCheck);
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            CheckPerfectNumber();
        }
    }
}
