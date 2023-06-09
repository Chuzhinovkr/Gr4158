﻿// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
string LineGen(int num, int pow)
{
    string res = "";
    for (int i = 1; i<=num;i++)      
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}
int numN = ReadData("Введите число N: ");
Console.WriteLine(LineGen(numN,1));
Console.WriteLine(LineGen(numN,2));
