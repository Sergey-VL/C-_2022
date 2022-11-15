﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new Int32[5, 4];

randomFilling(array, 0, 10);
arrayOutput(array);
smallestSumOfRowElements(array);

void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void smallestSumOfRowElements(int[,] arr)
{
    int sum = 0;
    int smallestSum = 0;
    int row = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (i == 0)
        {
            smallestSum = sum;
        }

        if (smallestSum > sum)
        {
            Console.WriteLine($"");
            smallestSum = sum;
            row = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов: {row + 1}");
}

void arrayOutput(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
    }
}