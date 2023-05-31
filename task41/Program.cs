// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int FindBiggestZero(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Enter number: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0)
            count++;
    }
    return count;
}

int M = Prompt("Enter M: ");
Console.WriteLine($"Count number biggest 0 is: {FindBiggestZero(M)}");