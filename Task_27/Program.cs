// 27. Определить количество цифр в числе

Console.WriteLine("Введите число:");

long n = Convert.ToInt64(Console.ReadLine());

long razryadnost(long n)
{
    long razr = 0;
    long s = Math.Abs(n);
    if (n == 0)
    {
        return 1;
    }
    while (s >= 1)
    {
        s = s / 10;
        razr++;
    }
    return razr;
}

Console.WriteLine($"В указанном числе {razryadnost(n)} цифр");