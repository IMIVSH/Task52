// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

void PrintInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int[,] GetArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        PrintInColor(j + "\t", ConsoleColor.Green);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t", ConsoleColor.Green);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMiddleArithmetic(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Средние арифметические по столбцам");
    Console.ResetColor();
    double[] middleArray = new double[array.GetLength(1)];
    for (int m = 0; m < middleArray.Length; m++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            double middleArithmetic = 0.0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                {
                    middleArithmetic = middleArithmetic + array[i,j];
                }
            }
            middleArithmetic = middleArithmetic / array.GetLength(1);
            middleArithmetic = Math.Round(middleArithmetic,1);
            middleArray[m] = middleArithmetic;
        }
    }
    for (int m = 0; m < middleArray.Length; m++)
    {
        Console.Write(" \t");
        Console.Write(middleArray[m]);
    }
}

int[,] array = GetArray(3, 3, 1, 9);
PrintArray(array);
FindMiddleArithmetic(array);