//Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 3D пространстве.

// Чтения данных консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Находим расстояние между точками в пространстве
double CalcLen2D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
}

int x1 = ReadData("Введите координату x точки А: ");
int y1 = ReadData("Введите координату y точки А: ");
int z1 = ReadData("Введите координату z точки А: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату x точки B: ");
int z2 = ReadData("Введите координату z точки А: ");

//Выводит результат
Console.WriteLine("Растояние между точками A b B: " + CalcLen2D(x1, y1, z1, x2, y2, z2));
