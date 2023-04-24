// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до {0}:", N);
for (int i = 2; i <= N; i += 2) 
Console.Write("{0} ", i);