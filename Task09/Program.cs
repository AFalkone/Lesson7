﻿// Задача 9. 
// Напишите программу, которая 
// 1. выводит случайное число 
// 2. из отрезка [10, 99] и 
// 3. показывает наибольшую цифру.

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); // (10, 99 + 1)
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// для начала получаем каждую цифру в отдельности
int firstDigit = number / 10; // для двухзначного числа делим на 10 (отбросится дробная часть)
int secondDigit = number % 10; // остаток деления на 10 (ближайшее чсило которое делиться на 10 это 70, 8 остается в остатке)

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
// }

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");


