Console.WriteLine("Введите трехзначгое число");
string? numNLine = Console.ReadLine();
if (numNLine != null)
{
    int num = int.Parse(numNLine);
    int res = num%10;

Console.WriteLine(res);
}