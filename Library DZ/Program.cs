using System;

namespace MatrixSum
{
    class Program
    {
        static void Main()
        {
            int n = 8; // количество строк
            int m = 3; // количество столбцов
            int[,] matrix = new int[n, m];

            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Элемент [{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = SumOfMultiplesOfThree(matrix);
            Console.WriteLine($"Сумма элементов матрицы, кратных 3: {sum}");
        }

        static int SumOfMultiplesOfThree(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 3 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}