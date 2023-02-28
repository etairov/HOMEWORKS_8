/*Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
//--------------------------------------

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
            Console.Write($"({matrix[i, j]}) ");
        }

        Console.WriteLine();
    }
}

//------------------------------------

int[,] Multiplication(int[,] matrix, int[,] matrixTwo)
{
    int[,] multi = new int[matrix.GetLength(0), matrixTwo.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int k = 0; k < matrixTwo.GetLength(0); k++)
            {
                multi[i, j] += matrix[i, k] * matrixTwo[k, j];
            }
        }
    }
    return multi;
}

//------------------------------------

int[,] matrix = InitMatrix(2, 2);
int[,] matrixTwo = InitMatrix(2, 2);
int[,] multi = Multiplication(matrix, matrixTwo);

Console.WriteLine($"Заданы матрицы: ");
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();

PrintMatrix(matrixTwo);
Console.WriteLine();

Console.WriteLine($"Матрица- произведение: ");
Console.WriteLine();

PrintMatrix(multi);
