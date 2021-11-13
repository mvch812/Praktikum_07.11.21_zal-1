// 25. Найти сумму чисел от 1 до А

// ряд натуральных чисел образует арифметическую прогрессию с шагом 1.
// Сумма первых n членов арифметической прогрессии определяется формулой:
// S = (a1+an)*n/2;
// a1 = 1, а значит S = (n+1)*n/2

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());

long summa1(long i) // не оптимальный метод
{
    long sum = 0;
    for (long x = 1; x <= i; x++)
    {
        sum = sum + x;
    }
    return sum;
}



long summa2(long i) // оптимальный метод через формулу
{
    return ((i + 1) * i) / 2;
}

// Console.WriteLine($"Сумма чисел от 1 до {i} = {summa1(i)}");

DateTime dt = DateTime.Now; // записываем текущее время до выполнения метода
Console.WriteLine($"Сумма чисел от 1 до {i}  = {summa1(i)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // считаем время выполнения операции в милисекундах
dt = DateTime.Now;
Console.WriteLine($"Сумма чисел от 1 до {i}  = {summa2(i)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);