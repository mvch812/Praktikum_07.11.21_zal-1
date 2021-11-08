// 24. Найти кубы чисел от 1 до N

double i = new Random().Next(1, 100);

void kub(double i)
{
    double kubb = 0;
    for (int x = 1; x <= i; x++)
    {
        kubb = Math.Pow(x, 3);
        Console.WriteLine($"Куб числа {x} = {kubb}");
    }
}

kub(i);


