using System;

namespace PlusMatrices
{
    class Program
    {
        private static void PlusMatrices()
        {
            int MatrixSize;
            int i;
            int j;
            int[,] ArrayFirst = new int[50, 50];
            int[,] ArraySecond = new int[50, 50];
            int[,] ArraySum = new int[50, 50];

            Console.WriteLine("Enter size of matrix: ");
            MatrixSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Import elements into the first matrix: \n");
            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize; j++)
                {
                    Console.Write("Element --({0}, {1}): ", i, j);
                    ArrayFirst[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Import elements into the second matrix: \n");
            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize; j++)
                {
                    Console.Write("Element --({0}, {1}): ", i, j);
                    ArraySecond[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPrint first matrix: ");
            for (i = 0; i < MatrixSize; i++)
            {
                Console.Write("\n");
                for (j = 0; j < MatrixSize; j++)
                {
                    Console.Write("{0}\t", ArrayFirst[i, j]);
                }
            }

            Console.WriteLine("\nPrint second matrix: ");
            for (i = 0; i < MatrixSize; i++)
            {
                Console.Write("\n");
                for (j = 0; j < MatrixSize; j++)
                {
                    Console.Write("{0}\t", ArraySecond[i, j]);
                }
            }

            //plus 2 matrices
            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize; j++)
                {
                    ArraySum[i, j] = ArrayFirst[i, j] + ArraySecond[i, j];
                }
            }

            Console.WriteLine("\nPrint sum matrix: ");
            for (i = 0; i < MatrixSize; i++)
            {
                Console.Write("\n");
                for (j = 0; j < MatrixSize; j++)
                {
                    Console.Write("{0}\t", ArraySum[i, j]);
                }
            }

            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            PlusMatrices();
        }
    }
}
