//напишите программу, которая выводит случайное 
//число из отрезка [10,99]
//и показывает наибольшую цифру числа

Console.Clear();

int number=new Random().Next(10,100); // всегда не берет последнее число, поэтому указываем +1
int a1 =number/10; // целочисленное деление берем только левую цифру
int a2=number%10; // деление с которого берем остаток

int max=a1;

if (a2>max) max=a2;
Console.WriteLine($"Максимальная цифра числа {number} --> {max}");