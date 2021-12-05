// 70.	Найти сумму цифр числа
int n = -3095;
int SummNumberElements(int n, int div = 1)
{
    if (n / div == 0) return 0;
    else return ((Math.Abs(n / div) % 10)) + SummNumberElements(n, div * 10);
}
Console.WriteLine($"Сумма цифр числа {n} = {SummNumberElements(n)} ");
