//Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int number=new Random().Next(100,1000); // всегда не берет последнее число, поэтому указываем +1
Console.WriteLine(number);
int a1 =number/100; // целочисленное деление берем только левую цифру
int a3 =number%10;

int result=a1*10+a2;

Console.WriteLine(result);