// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
    {
    Console.WriteLine("Нечетное");       
    }
        else
        {
        Console.WriteLine("Четное");
        }
