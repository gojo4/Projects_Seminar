//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
/*
int value = new Random().Next(100,1000);
    Console.WriteLine(value);
int a = (value % 100)/10;
    Console.WriteLine(a);
*/

//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*
int value = new Random().Next(10,100000);
//int value = 68;
Console.WriteLine(value);

if(value / 100 > 0)
    {
        string str = value.ToString();
        Console.WriteLine(str[2]);
    }
else 
    {
        Console.WriteLine("Третьей цифры нет");
    }
    */


// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());

if (value >= 6 && value < 8)
    {
        Console.WriteLine("Выходной день");
    }
else if(value >= 1 && value < 6)
    {
        Console.WriteLine("Будний день");
    }
 else if (value > 7)
    {
        Console.WriteLine("Такого дня недели у нас нет");
    }

 