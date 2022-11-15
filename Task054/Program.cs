// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new Int32[4, 5];

randomFilling(array, 0, 10);
Console.WriteLine("Массив рандомный несортированный:");
arrayOutput(array);
sortLine(array);
Console.WriteLine("Массив отсортирован по убыванию:");
arrayOutput(array);

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

void sortLine(int[,] arr)
{
    for (var i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {

                if (arr[i, j] > arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
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