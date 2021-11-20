// 28. Подсчитать сумму цифр в числе

Console.WriteLine("Введите число:");

long n = Convert.ToInt64(Console.ReadLine());

long razryadnost(long n)
{    
    long s = Math.Abs(n);
    long p = 0;
    if (n == 0)
    {
        return 0;
    }
    while (s >= 1)
    {
        p = p + s % 10;
        s = s / 10;
    }
    return p;
}

Console.WriteLine($"Сумма цифр в указанном числе равна {razryadnost(n)}");