//Задача 21: Написать программу, которая проверяет пятизначное число на палиндром.

Console.WriteLine("Введите пятизначное число:");

int n = Convert.ToInt32(Console.ReadLine());

bool Polindrom(int n)
{
    return (((n / 10000) == n % 10) && ((n / 1000 % 10) == (n / 10 % 10)));
}
Console.WriteLine($"Введенное число полиндром? Ответ: {Polindrom(n)}");

// int m1 = (n / 10000);
// int m2 = n % 10;
// int m3 = (n / 1000 % 10);
// int m4 = (n / 10 % 10);
// Console.WriteLine($"{m1} {m2} {m3} {m4}");