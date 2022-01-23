// 3.	Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

string MaxMinNumber(int a, int b)
{
    if (a > b) return $"Число {a} - большее, число {b} - меньшее";
    else return $"Число {b} - большее, число {a} - меньшее";
}
Console.WriteLine(MaxMinNumber(a, b));