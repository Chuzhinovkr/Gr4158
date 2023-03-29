// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и
// 23

Console.WriteLine("Введите числа");
int num = int.Parse(Console.ReadLine()??"0");
bool test1 = (num%7==0);
bool test2 = (num%23==0);
if (test1 && test2)
{
    Console.WriteLine("кратно обоим");
}
else 
{
    Console.WriteLine("некратно обоим");
}