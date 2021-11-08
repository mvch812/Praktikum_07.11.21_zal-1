// 24. Найти кубы чисел от 1 до N

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());

void kub(long i)
{
    double kubb = 0;
    for (int x = 1; x <= i; x++)
    {
        kubb = Math.Pow(x, 3);
        Console.WriteLine($"Куб числа {x} = {kubb}");
    }
}

kub(i);


