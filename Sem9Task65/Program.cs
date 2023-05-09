// Задайте значения M и N. Напишите 
// программу, которая найдёт все натуральные элементы
//  в промежутке от M до N.


//Метод ввода
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void FromMToN(int m, int n)
{
    if (m <= n)
    {
        Console.Write(n + " ");
        FromMToN(m, n - 1);
    }
    else
    {
        return;
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
if (m>n)
{
  int buf = m;
  m = n;
  m = buf;
}
FromMToN(m, n);


