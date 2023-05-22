// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] arrayM = new int[n, m];

// GetArray();
// PrintArray(arrayM);
// SortArray(arrayM);
// Console.WriteLine("---------------------");
// PrintArray(arrayM);

// void GetArray()
// {
//     for (int i = 0; i < arrayM.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayM.GetLength(1); j++)
//         {
//             arrayM[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] arrayM = new int[rows, columns];
// int minSumRow = int.MaxValue;
// int indexRow = 0;

// GetArray();
// PrintArray(arrayM);
// SumRows();

// void GetArray()
// {
//     for (int i = 0; i < arrayM.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayM.GetLength(1); j++)
//         {
//             arrayM[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SumRows()
// {
//     for (int i = 0; i < arrayM.GetLength(0); i++)
//     {
//         int rowSum = 0;
//         for (int j = 0; j < arrayM.GetLength(1); j++)
//         {
//             rowSum += arrayM[i,j];
//         } 
//         if (rowSum < minSumRow)
//         {
//             minSumRow = rowSum;
//             indexRow = i;
//         }
//         Console.WriteLine($"\nСумма {i} строки - {rowSum}");
//     }
//     Console.WriteLine($"{indexRow} - строка с наименьшей суммой");
// }

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите кол-во строк первой матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов первой матрицы и кол-во строк второй: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
// int t = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = new int[n,m];
// int[,] matrix2 = new int[m, t];

// int[,] resultMatrix = new int[n, t];

// GetMatrix(matrix1);
// Console.WriteLine("Первая матрица: ");
// PrintMatrix(matrix1);

// GetMatrix(matrix2);
// Console.WriteLine("Вторая матрица: ");
// PrintMatrix(matrix2);
// MultiplyMatrix(matrix1, matrix2, resultMatrix);
// Console.WriteLine("Результат: ");
// PrintMatrix(resultMatrix);

// void GetMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 sum += matrix1[i, k] * matrix2[k, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }
// }
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите x: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[n, m, k];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int t = 0; t < array.GetLength(2); t++)
        {
            array[i, j, t] = new Random().Next(10, 100);
            Console.Write(array[i,j,t] + $"({i},{j},{t})  ");  
        }
        Console.WriteLine();
    }
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



// Console.WriteLine($"Введите размер массива X x Y x Z: ");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }