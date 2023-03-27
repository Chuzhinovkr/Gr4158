//Считываем данные с консоли
string? inLine = Console.ReadLine();

//Проверяем, чтобы данныебыли не пустыми
if(inLine!=null)
{
    //Просим введенное число
    int inNumber = int.Parse(inLine);
    
    //Находим квадрат числа
    int outNumber = inNumber*inNumber;
    int outStrtPow = (int)Math.Pow(inNumber,2);
    
    //Выводим данные в консоль
    Console.WriteLine(outNumber);

    //Выводим данные в консоль
    Console.WriteLine(outStrtPow);
 }