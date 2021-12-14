  using System;

namespace MatrixTraill
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix total = new Matrix();
            Random number = new Random();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] matrix = new int[y, x];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix[i, j] = number.Next(100);
                }
            }
            total.Trace(matrix);

        }
    }
}
