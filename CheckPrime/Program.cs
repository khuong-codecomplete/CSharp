using System;

namespace CheckPrime
{
    class Program
    {

        private static void CheckPrime()
        {
            
            int Count = 0;
            int NumberNeedCheck;

            Console.Write("Enter number to check prime: ");
            NumberNeedCheck = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= NumberNeedCheck; i++)
            {
                if (NumberNeedCheck % i == 0)
                {

                    Count++;

                }                
            }

            if (Count == 2)
            {
                Console.WriteLine("{0} is a prime number.", NumberNeedCheck);
            }

            else
            {
                Console.WriteLine("{0} is not a prime number", NumberNeedCheck);
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            CheckPrime();
        }
    }
}
