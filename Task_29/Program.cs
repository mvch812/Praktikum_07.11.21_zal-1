// // 29. Написать программу вычисления произведения чисел от 1 до N (т.е. факториал)

Console.WriteLine("Введите число:");

long i = Convert.ToInt64(Console.ReadLine());

//Решение 1:
// long proizv(long i)
// {
//     long pr = 1;
//     for (long x = 1; x <= i; x++)
//     {
//         pr = pr * x;
//         Console.WriteLine(pr);
//     }
//     return pr;
// }
// DateTime dt = DateTime.Now; // записываем текущее время до выполнения метода
// Console.WriteLine($"Произведение чисел от 1 до {i} = {proizv(i)}");
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // считаем время выполнения операции в милисекундах

// // Решение через рекурсию:
long Factorial (long i)
{
    // 1!=1 факториал 1 = 1
    //0!=1 факториал 0=1
    if (i==1) return 1;
    else return i*Factorial(i-1);
}
DateTime dt = DateTime.Now; // записываем текущее время до выполнения метода
Console.WriteLine($"Произведение чисел от 1 до {i} = {Factorial(i)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // считаем время выполнения операции в милисекундах
