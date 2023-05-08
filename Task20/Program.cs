// // Напишите программу, которая
// принимает на вход координаты двух точек и
// находим расстояние между ними в 2 D прострастве

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter (xCoordinate, yCoordinate);
// string result = quarter > 0 
//                 ? $"Указанные координаты соответствуют четверти -> {quarter}"
//                 : "Введены некорректные корректные координаты";
// Console.WriteLine(result);  

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

double d = Math.Sqrt(5);
double num = 5.099786232;
double numRound = Math.Round(num, 2);
Console.WriteLine(numRound);
