//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

// Чтение данных
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

Console.WriteLine("A в степени B: ");
 ToDegree(numberA,numberB);