using System;

namespace SortArray
{
    class Program
    {
        private static void SortArrayAscending()
        {

            int[] Array = new int[20];
            int NumberOfElements;
            int i;
            int j;
            int Temp;

            Console.WriteLine("Enter the number of elements for the array: ");
            NumberOfElements = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} element into the array: \n", NumberOfElements);
            for ( i = 0; i < NumberOfElements; i++)
            {
                Console.Write("Element {0}: ", i);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for ( i = 0; i < NumberOfElements; i++)
            {

                for ( j = i + 1; j < NumberOfElements; j++)
                { 

                    if ( Array[j] < Array[i])
                    {
                        Temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Temp;
                    }
                }
            }

            Console.WriteLine("The elements of the array are in ascending order: ");
            for ( i = 0; i < NumberOfElements; i++)
            {
                Console.Write("{0} ", Array[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            SortArrayAscending();

        }
    }
}
