using System;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            var matrixOperations = new MatrixOperations();
            matrixOperations.RotateMatrix(a, 3, 3);
        }
    }
}
