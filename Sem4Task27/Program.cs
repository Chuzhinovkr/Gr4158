// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.

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
    Console.WriteLine(msg+res);
}
int SumSimple(int num)
{
    int res = 0;
while (num > 0)
{
res += num % 10;
num = num / 10;
}
return res;
}
int num=ReadData("Введите число: ");
int res = SumSimple((int)num);
PrintResult("Сумма чисел: ", (int)res);
