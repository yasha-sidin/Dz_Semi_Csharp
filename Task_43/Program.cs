// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Находим точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
void GetIntersectionPointOfTwoStraightLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых с данными значениями коэфициентов: ({Math.Round(x, 1)}; {Math.Round(y, 1)})");
}

// -----------------------------------------------------------------------------------

Console.WriteLine("Введите значения коэфициентов уравнения первой прямой: ");
Console.Write("b1 = ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значения коэфициентов уравнения второй прямой: ");
Console.Write("b2 = ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = int.Parse(Console.ReadLine());

GetIntersectionPointOfTwoStraightLines(b1, k1, b2, k2);