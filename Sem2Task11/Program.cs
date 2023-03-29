// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа. 

int num = new System.Random().Next(100,1000);
Console.WriteLine(num);
int firstNum = num/100;
int lustNum = num%10;
int nextNum = firstNum*10+lustNum;
Console.WriteLine(nextNum);