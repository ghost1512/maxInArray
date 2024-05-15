using System;

class MatrixMaxElementFinder
{
    static void Main()
    {
        Console.WriteLine("Nhập số hàng của ma trận:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập số cột của ma trận:");
        int cols = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, cols];

        Console.WriteLine("Nhập các phần tử của ma trận:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double maxElement = double.MinValue;
        int maxRow = 0, maxCol = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine($"Phần tử lớn nhất là: {maxElement} tại tọa độ ({maxRow}, {maxCol})");
    }
}
