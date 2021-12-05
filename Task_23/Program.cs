
// 23. Показать таблицу квадратов чисел от 1 до N 

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());
void quadr(double i)
{
    Console.WriteLine($"| число | квадрат числа |");
    Console.WriteLine($"_________________________");
    double q = 0;
    for (int x = 1; x <= i; x++)
    {
        q = Math.Pow(x, 2);
        Console.WriteLine($"|{x,6} | {q,14} |");
    }
}
quadr(i);

