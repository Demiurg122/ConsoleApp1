/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

/*
class Program
{
    static void PrintRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintRange(m + 1, n);
        }
    }
    static void Main(string[] args)
    {
        int m = 1;
        int n = 10;

        Console.WriteLine($"Натуральные числа от m до n");
        PrintRange(m, n);
    }
}
*/

/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/

/*
class Program
{
    static int Ackerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackerman(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
        else
        {
            // В случае, если входные данные не соответствуют условиям, вернуть -1
            return -1;
        }
    }
    static void Main(string[] args)
    {
        //Задаем значения m и n
        int m = 3;
        int n = 4;

        //Вычисляем значение функции Аккермана для заданных m и n
        int result = Ackerman(m, n);
        Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n}:");
    }
}
*/

/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.*/

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main(string[] args)
    {
        //Произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элемент массива начинается с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }
}