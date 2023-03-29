//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите первое число: ");
string? numLine = Console.ReadLine();
if (numLine != null)
{
    int num = int.Parse(numLine);
    


if (num % 2 == 0)
    {
 Console.WriteLine(num + " - Четное число: ");
    }
 else
    {
 Console.WriteLine(num + " - Нечетное число");
    }
}