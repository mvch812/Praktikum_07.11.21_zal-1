// 9.	Показать четные числа от 1 до N

int n = 77;
string numbers1toN(int n)
{
    string print = string.Empty;

    for (int i = 2; i < n + 1; i++)
    {
        if (i % 2 == 0) print += $"{i} ";
    }
    return print;
}

Console.WriteLine(numbers1toN(n));