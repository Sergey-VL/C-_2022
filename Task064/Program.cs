// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число");

int number = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(number);


void printNaturalNumbers(int n)
{

    if (n == 1)
    {
        Console.WriteLine(n);
    }
    else
    {
        Console.Write(n);
        printNaturalNumbers(n - 1);
    }
}