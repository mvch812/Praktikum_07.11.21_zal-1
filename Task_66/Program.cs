// 66.	Показать натуральные числа от 1 до N, N задано

string PrintNumbers1toN(int n)
{
    if (n == 1) return "1";
    else return $"{PrintNumbers1toN(n - 1)} {n}";
}

Console.WriteLine(PrintNumbers1toN(50));

