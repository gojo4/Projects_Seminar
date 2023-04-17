// 1. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string value = Console.ReadLine();
int i = value.Length;

if (i == 5)
{
    if (value[0] == value[4] && value[1] == value[3])
    {
        Console.WriteLine($"{value} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{value} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"Число: {value} - не является пятизначным");
}


// 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки ");
 int x1 = Convert.ToInt32(Console.ReadLine());
 int y1 = Convert.ToInt32(Console.ReadLine());
 int z1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты второй точки ");
 int x2 = Convert.ToInt32(Console.ReadLine());
 int y2 = Convert.ToInt32(Console.ReadLine());
 int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine("Расстояние между точками: " + Math.Round(d,3));


// 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

for (int i=1; i <= value; i++ )
    {
        Console.WriteLine(Math.Pow(i,3));
    }    