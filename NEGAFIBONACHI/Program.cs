// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] Fibonachi(int num)
{
    int[] array = new int[num];
    int[] array_hard = new int[num * 2 - 1];
    
    if (num > 0)
    {
        array [0] = 0;
        array [1] = 1;        
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = array[i - 2] + array[i - 1];
        }   
    }

    for (int i = 0; i < array_hard.Length/2 ; i++)
    {        
        array_hard[i] = array[array.Length - i - 1] * Convert.ToInt32(Math.Pow(-1, i + 1));
    }

    for (int i = array_hard.Length/2; i < array_hard.Length; i++)
    {        
        array_hard[i] = array[i - array_hard.Length/2];
    }


    return array_hard;    
}


int num = Prompt("Enter lenght's negafibonachi:");

int[] res = Fibonachi(num);

foreach (int item in res)
{
    Console.Write($"{item} ");
}