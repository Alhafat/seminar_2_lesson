// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите любое число: ");
int number1=int.Parse(Console.ReadLine()!);
int number2=7;
int number3=23;

int result=number1%number2;
int result2=number1%number3;

if ((result==0)&&(result2==0))
{
    Console.WriteLine($"Число {number1} кратно {number2} и {number3}");
}
else
{
    Console.WriteLine($"Число {number1} не кратно {number2} и/или {number3}");
}