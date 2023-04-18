using System;

namespace IMATP5_andras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le nombre N :\n");
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
            string triangle = Triangle(n);
            Console.WriteLine(triangle);
        }

        static string Triangle(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
                    }
                }
            }

            string triangle = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    triangle += matrix[i, j] + " ";
                }
                triangle += "\n";
            }
            return triangle;
        }
    }
}
