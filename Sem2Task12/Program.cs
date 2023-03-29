// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе
// число кратным первому. Если второе число
// некратно первому, то программа выводит остаток от
// деления. 

Console.WriteLine("Введите числа");
int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = Convert.ToInt32(Console.ReadLine());
bool res = (num1 % num2 == 0);
if (res)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число некратно первому, остаток:" + num1 % num2);
}

