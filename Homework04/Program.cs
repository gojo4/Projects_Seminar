// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

int temp = num1;

for (int i = 1; i < num2; i++)
{
    temp = temp * num1;
}
Console.WriteLine("Результат: " + temp);

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int GetSumNum()
{
    while (value > 0)
    {
        int num = value % 10;
        value = value / 10;
        sum = sum + num;
    }
    return sum;
}
Console.WriteLine("Сумма цифр: " + GetSumNum());


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите элементы массива: ");
int [] arrayNum = new int [8];

for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + String.Join(", ", arrayNum) + "]");