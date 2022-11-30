// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

String[] array = new String[5];
String[] newArray = new String[array.Length];
Console.WriteLine("Введите 5 слов (после ввода слова нажать Enter)): ");

for (int i = 0; i < array.Length; i++)
{
    String word = Console.ReadLine();
    array[i] = word;
}

Console.WriteLine(" ");
Console.WriteLine("Первоначальный массив слов: ");
arrayOutput(array);
formationNewArray(array, newArray);
Console.WriteLine("Итоговый массив слов, соответствующий условиям: ");
arrayOutput(newArray);

void formationNewArray(String[] array, String[] newArray)
{
    int j = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j++] = array[i];
        }
    }
}

void arrayOutput(String[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}