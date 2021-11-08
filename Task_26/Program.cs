// 26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число, которое необходимо возвести в степень:");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень возведения:");
int m = Convert.ToInt32(Console.ReadLine());

double stepen(double n, double m)
{
    double st = n;
    for (int x = 1; x < m; x++)
    {
        st = st * n;
    }
    return st;
}

Console.WriteLine($"Число {n} в степени {m} = {stepen(n, m)}");



