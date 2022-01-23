// 2.	По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

bool squareNumber(int a, int b)
{
    return (a == b * b);
}
Console.WriteLine($"Число {a} является квадратом числа {b}? Отет:{squareNumber(a, b)} ");