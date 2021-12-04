// 68.	Показать натуральные числа от M до N, N и M заданы

int PrintNumbersNtoM(int i, int n)
{
    Console.Write($"{i} ");
    if (i == n) return n;
    return PrintNumbersNtoM(i + 1, n);
}

PrintNumbersNtoM(7, 70);
