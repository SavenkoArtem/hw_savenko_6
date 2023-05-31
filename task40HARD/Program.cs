// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

double Prompt(string msg)
{
    Console.WriteLine(msg);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}


bool Check(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

double Perimeter(double a, double b, double c)
{
    return a + b + c;
}

bool IsEquilateral(double a, double b, double c)
{
    bool flag = false;
    if (a == b && b == c)
        flag = true;
    return flag;
}

bool IsIsosceles(double a, double b, double c)
{
    bool flag = false;
    if ((a == b && b != c) || (a == c && c != b) || (c == b && b != a))
        flag = true;
    return flag;
}

double[] Angles(double a, double b, double c)
{
    double CB = Math.Acos((b*b + c*c - a*a) / (2 * b * c)) * 180 / Math.PI;
    double AB = Math.Acos((b*b + a*a - c*c) / (2 * a * b)) * 180 / Math.PI;
    double CA = Math.Acos((a*a + c*c - b*b) / (2 * a * c)) * 180 / Math.PI;

    double[] res = new double[] {CB, AB, CA};
    return res;
}


double a = Prompt("Enter side a: ");
double b = Prompt("Enter side b: ");
double c = Prompt("Enter side c: ");

if (!Check(a, b, c))
{
    Console.WriteLine("This is not triangle!");
}
else
{
    double p = Perimeter(a, b, c);
    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    double[] angles = Angles(a, b, c);

    Console.WriteLine($"The perimeter is: {p}");
    Console.WriteLine($"The area is: {s}");
    Console.WriteLine($"The angles CB is: {angles[0]}");
    Console.WriteLine($"The angles AB is: {angles[1]}");
    Console.WriteLine($"The angles CA is: {angles[2]}");


    if (IsEquilateral(a, b, c))
        Console.WriteLine("Triangle is equilateral!");
    else
        Console.WriteLine("Triangle is NOT equilateral!");

    if (IsIsosceles(a, b, c))
        Console.WriteLine("Triangle is Isosceles!");
    else
        Console.WriteLine("Triangle is NOT Isosceles!");


}
