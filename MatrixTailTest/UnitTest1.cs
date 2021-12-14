using System;
using Xunit;

namespace MatrixTailTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = 3;
            int y = 3;
            int[,] matrix = new int[y, x];
            matrix[0, 0] = 50;
            matrix[0, 1] =  12;
            matrix[0, 2] = 85;
            matrix[1, 0] = 26;
            matrix[1, 1] = 40;
            matrix[1, 2] = 72;
            matrix[2, 0] = 94;
            matrix[2, 1] = 41;
            matrix[2, 2] = 69;
            int expected = 159;
            var a = new MatrixTraill.Matrix();
            int result = a.Trace(matrix);
            Assert.Equal(expected, result);

        }
    }
}
