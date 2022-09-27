using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class arrays
    {
        public static void Main()
        {
            Array_1D();
            Array_2D();
            Jagged_Array();

        }
        public static void Array_1D()
        {
            int[] array = new int[] {1,2,3};
            Console.WriteLine("1-D array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Functions");
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Count());
            Console.WriteLine(array.Sum());

            Console.WriteLine(array.Average());
            Array.Sort(array);
            Console.WriteLine("Sorted Array");
            foreach(int j in array)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Sorted Array in Reverse Order");
            Array.Reverse(array);
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }
        }
        public static void Array_2D()
        {
            int[,] array = new int[,]
            {
                {1,2,3,4},
                {5,6,7,8}
            };
            Console.WriteLine("2_d Array");
            for(int i = 0; i < array.GetLength(1);i++)
            {
                for(int j=0;j<array.GetLength(1);j++)
                {
                    Console.Write(array[i,j]+"\t");

                }
           
                Console.WriteLine("\n");

            }
        }
        public static void Jagged_Array()
        {
            int[][] array = new int[][]
            {
                new int[3]{1,2,3},
                new int[5]{4,5,6,7,8},
                new int[2]{9,10}
            };
            for(int i=0;i<array.Length;i++)
            {
                for(int j = 0; j < array[i].Length;j++)
                {
                    Console.WriteLine(array[i][j] + "\t");

                }
                Console.WriteLine("\n");
            }
        }
    }
}
