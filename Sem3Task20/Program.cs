// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// Чтения данных консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Находим расстояние между точками на плоскости
double CalcLen2D(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2));
}

int x1 = ReadData("Введите координату x точки А: ");
int y1 = ReadData("Введите координату y точки А: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату x точки B: ");
Console.WriteLine("Растояние между точками A b B: " + CalcLen2D(x1, y1, x2, y2));
