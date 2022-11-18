// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int from = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int to = Convert.ToInt32(Console.ReadLine());

printNaturalNumbers(from, to, 0);

void printNaturalNumbers(int numberStart, int numberStop, int sum)
{

    if (numberStart > numberStop)
    {
        Console.WriteLine($"Сумма элементов {sum}");
        return;
    }
    sum += (numberStart++);
    printNaturalNumbers(numberStart, numberStop, sum);
}