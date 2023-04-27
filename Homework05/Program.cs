// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arrayNum = new int [n];
int count = 0;
for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = new Random().Next(99,1000);
      if (arrayNum[i]%2 == 0)
        {
            count++;
        }      
}
Console.Write("[" + String.Join(", ", arrayNum) + "]" + "\nКоличество четных чисел -> " + count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arrayNum = new int [n];
int sum = 0;

for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = new Random().Next(101);
    if (i%2 != 0)
    {
        sum += arrayNum[i];
    }
}
Console.Write("[" + String.Join(", ", arrayNum) + "]" + "\nСумма -> " + sum);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] arrayNum = new double [n];

for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = Convert.ToDouble(new Random().Next(1001))/100;
}
double max = arrayNum[0];
double min = arrayNum[0];
for (int i = 0; i < arrayNum.Length; i++)
{
    if (max < arrayNum[i])
    {
        max = arrayNum[i];
    }
    else if (min > arrayNum[i])
    {
        min = arrayNum[i];
    }
}  
Console.Write("[" + String.Join(", ", arrayNum) + "]" + "\nMax: " + max + "\nMin: " + min + "\nРазница -> " + Math.Round((max - min),2));