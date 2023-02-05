// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double[] AverageInMatrix(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double total = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            total += matrix[i, j];
        }
        total /= matrix.GetLength(1);
        result[i] = total;
    }
    return result;
}

int[,] matr = GetRandomMatrix(m: 4, n: 5, minValue: 10, maxValue: 90);
PrintArray(matr);
double[] result = AverageInMatrix(matr);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", result)}");