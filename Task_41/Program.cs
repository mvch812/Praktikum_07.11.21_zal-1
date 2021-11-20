//Выяснить являются ли три числа сторонами треугольника 


Console.WriteLine("Введите число №1:");

long a = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите число №2:");

long b = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите число №3:");

long c = Convert.ToInt64(Console.ReadLine());

bool triangle(long a, long b, long c)
{
    return ((a < b + c) && (b < a + c) && (c < a + b));
}

Console.WriteLine($"Числа {a}, {b}, {c} являются сторонами треугольника? Ответ:{triangle(a, b, c)}");