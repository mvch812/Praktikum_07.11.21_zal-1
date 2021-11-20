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



DateTime dt = DateTime.Now; // записываем текущее время до выполнения метода
Console.WriteLine($"Число {n} в степени {m} = {stepen(n, m)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // считаем время выполнения операции в милисекундах


//решим вторым способом
// Console.WriteLine("Введите число, которое необходимо возвести в степень:");

// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень возведения:");
// int m = Convert.ToInt32(Console.ReadLine());

// double stepen(double n, double m)
// {
//     double ST = n;
//     int div = 2;
//     while (m != 1)
//     {
//         while (m % div == 0)
//         {
//             ST *= Math.Pow(ST, div);
//             m /= div;
//             Console.Write($"{ST} ");
//         }
//         div += 1;
//     }
//     return ST;
// }



// DateTime dt = DateTime.Now; // записываем текущее время до выполнения метода
// Console.WriteLine($"Число {n} в степени {m} = {stepen(n, m)}");
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // считаем время выполнения операции в милисекундах