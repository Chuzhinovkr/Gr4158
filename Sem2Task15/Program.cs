// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 

Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()??"0");

if ( day<1 && day>7 )
{
    Console.WriteLine(" не день недели! ");
}
else
{
    if (day>=1 && day<=5)
    {
    Console.WriteLine("Рабочий день недели");
    }
    else
    {
        Console.WriteLine("Выходной день");
     }
}
