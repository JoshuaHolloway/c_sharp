using System;

namespace _02_mult_table
{
    class Program
    {
        static void Main(string[] args)
        {
            //=================================================================
            // Multiplication-Table
            // ----------------------------------------------------------------
            int[,]  array2D = new int[3,2];
            int[,,] array3D = new int[2,3,4] 
                {
                    {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
                    {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
                };
            // ----------------------------------------------------------------
            int[,] matrix = new int[10,10];
            for(int i = 1; i <= 10; ++i)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    matrix[i-1,j-1] = i * j;
                    Console.Write(matrix[i-1,j-1] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
