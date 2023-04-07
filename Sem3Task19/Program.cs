// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

//Чтение данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Проверка на палиндромность
bool PalTest(int num)

{
    bool res = false;
    int D1 = num / 10000;
    int D5 = num % 10;
    int D2 = (num / 1000) % 10;
    int D4 = (num / 10) % 10;
    if (D1==D5 && D2==D4)  
    Console.WriteLine("Палиндром: ");
    else 
    Console.WriteLine("Не палиндром: " );
    res = true;
    if (num > 5)
    Console.WriteLine("Неверное число: " );

    return res;
}
int res = ReadData("Введите пятизначное число: ");
PalTest (res);
