/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
//--------------------------------------------------------------------------------------------------------------

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

void MinSummRowNumber(int[,] matrix)
{
    int index = 0;
    int minsum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов строки [{i}]: {sumRow}");

        if (i == 0)
        {
            minsum = sumRow;
        }
        else if (sumRow < minsum)
        {
            minsum = sumRow;
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index}. ");
}

int[,] matrix = InitMatrix(7, 3);

PrintMatrix(matrix);
Console.WriteLine();

MinSummRowNumber(matrix);

