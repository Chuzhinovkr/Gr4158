// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа.

System.Random numSintezator = new System.Random();

//Вариант 1
int rndNum = numSintezator.Next(10, 100);
Console.WriteLine(rndNum);
short firstNum = (short)(rndNum / 10);
short secondNum = (short)(rndNum % 10);

if (firstNum > secondNum)
{
    Console.WriteLine("Первое число больше " + firstNum + " второго " + secondNum);
}
else
{
    Console.WriteLine(secondNum);
}

//Вариант 2

char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
//23 -> "23" -> ['2','3']
Console.WriteLine(digits);
firstNum = (int)(digits[0])-48;
secondNum = (int)(digits[1])-48;
//<переменная> = (условие)?<значение1>:<значение2>;
// if(условие)
// {
//     <переменная> = <значение1>;
// }
// else
// {
//    <переменная> = <значение2>;
// }
int res = (firstNum>secondNum)?firstNum:secondNum;
Console.WriteLine(res);