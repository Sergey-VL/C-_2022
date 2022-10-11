// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Number = 0;
Console.WriteLine("Введите 3-х значное число: ");
Number = Convert.ToInt32(Console.ReadLine()); ;
if (Number >= 100 && Number <= 999)
{
    int DecreaseByTen = Number / 10;
    int LastDigit = DecreaseByTen % 10;
    Console.WriteLine("Вторая цифра числа = " + LastDigit);
}
else
{
    Console.WriteLine("Вы ошиблись, это не 3-х значное число! Попробуйте ещё разок, Вам точно повезёт! ");
}