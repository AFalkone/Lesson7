// Напишите программу, которая 
// 1. выводит случайное трехзначное число и 
// 2. удаляет вторую цифру этого числа.

// Пример:
// 456 -> 46
// 782 -> 82
// 718 -> 18

int DeleteSecondDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int number = new Random().Next(100, 1000); // (100, 999 + 1)
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
int result = DeleteSecondDigit(number);
Console.WriteLine(result);


