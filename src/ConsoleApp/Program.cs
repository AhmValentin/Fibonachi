int Fibonachi(int a)
{
    if (a < 1) return 0;
    if (a == 1) return 1;
    return Fibonachi(a - 1) + Fibonachi(a - 2);
}

int Fib(int b)
{
    if (b < 1) 
    {
        Console.WriteLine(0);
    }
    if (b == 1)
    {
        Console.WriteLine(0);
        Console.WriteLine(1);
    }
    int f1 = 0;
    int f2 = 1;
    int fn;
    if (b > 1)
    {
        Console.WriteLine(0);
        Console.WriteLine(1);
        for (int i = 0; i < b - 2; i++)
        {
            fn = f1 + f2;
            Console.WriteLine(fn);  
            f1 = f2;
            f2 = fn;
        }
    }
    return 0;
}

int i = 0;
while(i < 10)
{
    Console.WriteLine(Fibonachi(i));
    i++;
}

Fib(10);
