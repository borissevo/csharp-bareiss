using System;

namespace BareissAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[,]
            {
                { 1, 2, 3, 4 },
                { 1, 0, 2, 0 },
                { 0, 1, 2, 3 },
                { 2, 3, 0, 0 }
            };

            BareissAlg bareissAlg = new BareissAlg();
            Console.WriteLine($"Matrix determinant: {bareissAlg.Determinant(mat)}");
        }
    }
}
