// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a > c)
    {
    Console.WriteLine("maximum: " + a);
    }
    else
    Console.WriteLine("maximum: " + c);
}   
if(b > a)
{
    if(b > c)
    {
        Console.WriteLine("maximum: " + b);
    }
    else
    Console.WriteLine("maximum: " + c);
}