// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

Console.WriteLine("Введите число");
String num = Console.ReadLine();
char[] arr = num.ToCharArray();
if(arr.Length>=3)
{
    Console.WriteLine(arr[1]);
}