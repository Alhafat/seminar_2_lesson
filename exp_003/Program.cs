// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.


Console.Write("Введите любое число: ");
int number1=int.Parse(Console.ReadLine()!);
Console.Write("Введите любое число: ");
int number2=int.Parse(Console.ReadLine()!);

int result=number1%number2;

if (result==0)
{
    Console.WriteLine($"Число {number2} кратно числу {number1}");
}
else
{
    Console.WriteLine(result);
}