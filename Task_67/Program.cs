// 67.	Показать натуральные числа от N до 1, N задано

string PrintNumbersNto1(int n)
{
    if (n == 1) return "1";
    else return $"{n} {PrintNumbersNto1(n-1)}";
}

Console.WriteLine(PrintNumbersNto1(30));