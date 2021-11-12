// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());

void kub(long i)
{
    double kubb = 0;
    for (int x = 1; x <= i; x++)
    {
        if ((x % 10) % 2 == 0)
        {
            kubb = Math.Pow(x, 3);
            Console.WriteLine($"Куб числа {x} = {kubb}");
        }
    }
}

kub(i);

