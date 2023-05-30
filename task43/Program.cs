// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string msg)
{
    Console.WriteLine(msg);
    double num = Convert.ToInt32( Console.ReadLine());
    return num;
}


double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}


double k1 = Prompt("Enter k1: ");
double b1 = Prompt("Enter b1: ");
double k2 = Prompt("Enter k2: ");
double b2 = Prompt("Enter b2: ");

Console.WriteLine($"({FindX(k1, b1, k2, b2)}, {FindY(FindX(k1, b1, k2, b2), k1, b1)})");

