// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("Введите число");
String num = Console.ReadLine();
char[] arr = num.ToCharArray();
if(arr.Length>=3)
{
    Console.WriteLine(arr[2]);
}
else
{
    Console.WriteLine ("Такого числа нет!");
}