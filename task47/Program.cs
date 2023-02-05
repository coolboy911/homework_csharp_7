// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double RandomDouble(int minBorder, int maxBorder)  // случайное дробное число в диапазоне
{
    double randomDouble = new Random().NextDouble() * (maxBorder - minBorder) + minBorder;
    return randomDouble;
}

double[,] GetDoubleMatrix(int m, int n, int minBorder, int maxBorder)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = RandomDouble(minBorder, maxBorder);
        }
    }
    return matrix;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             
        }
        Console.WriteLine();
    }
}

Console.Clear();
double[,] matr = GetDoubleMatrix(m: 4, n: 5, minBorder: 10, maxBorder: 90);
PrintArray(matr);