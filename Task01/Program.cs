// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите значение A"); 
int number = Console.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение B"); 
double num2 = Console.ToInt32(Console.ReadLine()); 
if(num2 == num1 / num2)
{ Console.Write($"Число {num1} = квадрату числа {num2}"); } 
else 
{ Console.Write($"Число {num1} не равно квадрату числа {num2}"); }



