﻿// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например изначально массив выглядел во так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядет так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // опредлеяем количество строи и столбцов
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = matrix.GetLength(0); i  соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //  columns = matrix.GetLength(1); j соответствует столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

int[,] ArraySquareElementsWithEvenIndex (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i += 2)
    {
        for (int j = 0; j < matr.GetLength(1); j += 2)
        {
            matr[i, j] *= matr[i, j];
        }
        return matr;
    }
}

Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массив");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rows2, columns2, minimum, maximum); // лучше пользовательский код
PrintMatrix(array2d);
ArraySquareElementsWithEvenIndex (array2d);
Console.WriteLine("Массив с квадратами элементов с четными индексами");
PrintMatrix(array2d);


