// 25. Найти сумму чисел от 1 до А

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());

long summa(long i)
{
    long sum = 0;
    for (long x = 1; x <= i; x++)
    {
        sum = sum + x;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {i} = {summa(i)}");
