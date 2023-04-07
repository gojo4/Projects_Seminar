// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("Maxsimum: " + a + ";" + " Minimum: " + b);
    else
    Console.WriteLine("Maxsimum: " + b + "Minimum: " + a);

