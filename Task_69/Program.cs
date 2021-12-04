// 69.	Найти сумму элементов от N до M, N и M заданы

int SummNumbersNtoM(int n, int m)
{
    if (n == m) return m;
    else
    {
        if (n > m) return n + SummNumbersNtoM(n - 1, m);
        else return n + SummNumbersNtoM(n + 1, m);
    }
}

Console.WriteLine(SummNumbersNtoM(13, 5));

