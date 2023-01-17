// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да 
// ● -4, 16 -> да 
// ● 25, 5 -> да 
// ● 8,9 -> нет

Console.Write("Введите первое число: ");
int number1=int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2=int.Parse(Console.ReadLine()!);

int result=number2*number2;

if (number1-number2*number2==0)
{
    Console.WriteLine($"Квадрат числа {number2} равен введенному числу {number1}");
}
else
{
    if (number2-number1*number1==0)
    {
        Console.WriteLine($"Квадрат числа {number1} равен введенномучислу {number2}");
    }
    else
    {
    Console.WriteLine($"Ни одно введенное число не является квадратом другого");
    }
}