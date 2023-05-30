// Задача 43: 
// Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение k1: ");
        double k1 = double.Parse(Console.ReadLine()); // Считываем значение k1
        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine()); // Считываем значение b1
        Console.Write("Введите значение k2: ");
        double k2 = double.Parse(Console.ReadLine()); // Считываем значение k2
        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine()); // Считываем значение b2

        double[] point = FindIntersectionPoint(k1, b1, k2, b2); // Вызываем метод для вычисления точки пересечения

        Console.WriteLine($"Точка пересечения прямых: ({point[0]}, {point[1]})"); // Выводим координаты точки пересечения
    

    static double[] FindIntersectionPoint(double k1, double b1, double k2, double b2)
    {
        double x = (b2 - b1) / (k1 - k2); // Вычисляем координату x точки пересечения
        double y = k1 * x + b1; // Вычисляем координату y точки пересечения
        double[] point = new double[] { x, y }; // Создаем массив с координатами точки
        return point; // Возвращаем массив
    }