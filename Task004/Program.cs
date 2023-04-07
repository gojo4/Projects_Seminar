// See https://aka.ms/new-console-template for more information

int i = 1;
bool m = true;
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + N);
while(i <= N)
    {
        if (i % 2 == 0){
        Console.Write(i + ",");
        m = false;
        } 
        i++;  
    }
        if (m){ 
            Console.WriteLine("Четных чисел нет");
            }
