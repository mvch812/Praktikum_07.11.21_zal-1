// 29. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());

long proizv(long i)
{
    long pr = 1;
    for (long x = 1; x <= i; x++)
    {
        pr = pr * x;
        Console.WriteLine(pr);
    }
    return pr;
}

Console.WriteLine($"Произведение чисел от 1 до {i} = {proizv(i)}");

