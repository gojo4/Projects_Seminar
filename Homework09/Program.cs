// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNum(n);
void PrintNum(int n)
{
    if (n == 0)
    {
        return;
    }
    Console.Write(n + " ");
    PrintNum(n-1);
}

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введтите число N: ");

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

PrintNumbers(m, n);
void PrintNumbers(int m, int n)
{
    Console.Write(SumValue(m - 1, n));
}

int SumValue(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumValue(m, n);
        return result;
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введтите число N: ");

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int functionAkkerman = A(m, n);

Console.Write($"Function Akkerman = {functionAkkerman}");

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
}
