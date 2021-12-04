// 68.	Показать натуральные числа от M до N, N и M заданы


string PrintNumbersNtoM(int m, int n)
{
    if (m == n) return $"{n}";
    else
    {
        if (m > n) return $"{m} {PrintNumbersNtoM((m - 1), n)}";
        else return $"{m} {PrintNumbersNtoM((m + 1), n)}";
    }
}
Console.WriteLine(PrintNumbersNtoM(30, 70));


