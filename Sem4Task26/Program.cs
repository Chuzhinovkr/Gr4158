// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

// Чтение данных
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод вывода результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int CountDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + 1;
        num = num / 10;
    }
    return res;
}
int numA = ReadData("Введите число : ");
int resA = CountDigit(numA);
PrintResult("Количество чисел: ", (int)resA);