/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
//--------------------------------

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
SDFSDF