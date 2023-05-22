// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] arrayNum = new double[n,m];

for (int i = 0; i < arrayNum.GetLength(0); i++)
{
    for (int j = 0; j < arrayNum.GetLength(1); j++)
    {
        arrayNum[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        Console.Write("{0}\t", "[" +  arrayNum[i,j] + "]");
    }
    Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] arrayM = new int [n,m];

// for (int i = 0; i < arrayM.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayM.GetLength(1); j++)
//     {
//         arrayM[i,j] = new Random().Next(101);
//         Console.Write("{0}\t", "[" +  arrayM[i,j] + "]");
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите позицию элемента в строке: ");
// int rows = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите позицию элемента в столбеце: ");
// int columns = Convert.ToInt32(Console.ReadLine()) - 1;

// if (rows < 0 | rows > arrayM.GetLength(0) - 1 | columns < 0 | columns > arrayM.GetLength(1) - 1)
//     {
//     Console.WriteLine("Элемент не существует  ");
//     }
// else
//     {
//         Console.WriteLine("Значение элемента массива = {0}", arrayM[rows, columns]);
//     }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] arrayM = new int [n,m];
// for (int i = 0; i < arrayM.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayM.GetLength(1); j++)
//     {
//         arrayM[i,j] = new Random().Next(101);
//         Console.Write("{0}\t", "[" +  arrayM[i,j] + "] ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Среднее арифметическое элементов столбца: ");
// for (int j = 0; j < arrayM.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arrayM.GetLength(0); i++)
//     {
//         sum += arrayM[i,j];
//     }    
//     Console.Write("{0}\t", + Math.Round(sum / arrayM.GetLength(0), 1));
// }