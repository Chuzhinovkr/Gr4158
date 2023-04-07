// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.

//Чтение данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Увеличение числа N и вычисление его кубов
string LineGen(int num, int pow)
{
    string res = "";
    for (int i = 1; i<=num;i++)      
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}
//Ввод числа N
int numN = ReadData("Введите число N: ");
//Вывод числа N в строку
Console.WriteLine(LineGen(numN,1));
//Вывод кубов числа N в строку
Console.WriteLine(LineGen(numN,3));
