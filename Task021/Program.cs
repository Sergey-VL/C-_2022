// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Ax = Prompt("Введите координату точки A по оси х > ");
int Ay = Prompt("Введите координату точки A по оси y > ");
int Az = Prompt("Введите координату точки A по оси z > ");
int Bx = Prompt("Введите координату точки B по оси х > ");
int By = Prompt("Введите координату точки B по оси y > ");
int Bz = Prompt("Введите координату точки B по оси z > ");

double Length(int x, int y, int z)
{
    double result = Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) + (Az - Bz) * (Az - Bz));
    System.Console.WriteLine(result);
    return result;
}
Length(Ax, Ay, Az);
