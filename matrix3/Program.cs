using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix3
{
    internal class Program
    {
        static int[,] matrix = new int[5, 3];
        static int[] sum1 = new int[5];
        static int[] sum2 = new int[3];
        static void sumRow()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum1[i] = sum1[i] + matrix[i, j];
                }
            }
        }
        static void sumColumn()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum2[j] = sum2[j] + matrix[i, j];
                }
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            sumColumn();
            sumRow();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. Row Sum {1}\n", i + 1, sum1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}. Column Sum: {1}\n", i + 1, sum2[i]);
            }
            Console.ReadKey();
        }
    }
}
