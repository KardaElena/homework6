// // // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Алгоритм решения:
// 1) Вычесть из первого уравнения второе
// 2) Найти x
// 3) Найти y

double FindingX (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindingY (double b1, double k1, double b2, double k2, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.Clear();
Console.WriteLine("Введите переменную b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите переменную b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите переменную k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите переменную k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");
double x = FindingX(b1, k1, b2, k2);
double y = FindingY(b1, k1, b2, k2, x);
Console.WriteLine($"\n Координаты точки пересечения двух прямых: {x}, {y}");
Console.WriteLine();

