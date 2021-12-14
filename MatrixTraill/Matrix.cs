using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTraill
{
    public class Matrix
    {
        public int Trace(int[,] matrix)
        {
            int value = 0;
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
                try
                {
                    value += matrix[i, i];
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }
            Console.WriteLine(value);
            return value;
        }

    }
}
