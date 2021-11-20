// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());

// void kub(long i)
// {
//     double kubb = 0;
//     for (int x = 1; x <= i; x++)
//     {
//         if ((x % 10) % 2 == 0)
//         {
//             kubb = Math.Pow(x, 3);
//             Console.WriteLine($"Куб числа {x} = {kubb}");
//         }
//     }
// }

// kub(i);

// 30.1  Показать кубы, заканчивающиеся на четную цифру
void kub(long i)
{
    if (i < 1)
    {
        Console.WriteLine($"Число {i} не является натуральным.");
        return;
    }
    else
        for (int x = 2; x <= Math.Round(Math.Pow(i, 1.0 / 3.0)); x += 2) Console.WriteLine($"{Math.Pow(x, 3)} = {x}^3");
}
kub(i);
