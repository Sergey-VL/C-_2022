// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int N = Prompt("Введите пятизначное число > ");
void Palindrome(int N)
{
    if (N > 10000 && N < 100000)
    {
        int number1 = N / 10000;
        int number5 = N % 10;
        if (number1 == number5)
        {
            int number2 = N / 1000 % 10;
            int number4 = N / 10 % 10;
            if (number2 == number4)
            {
                System.Console.WriteLine("Да, Вы совершенно правы - это палиндром");
            }
            else
                System.Console.WriteLine("Нет");
        }
        else
            System.Console.WriteLine("Нет, попробуйте, пожалуйста ещё раз. Я верю, что у Вас всё получится!");
    }
    else
    {
        System.Console.WriteLine("Это не пятизначное число");

    }
}

Palindrome(N);
