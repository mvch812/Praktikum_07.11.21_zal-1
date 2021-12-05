// 72.	Написать программу возведения числа А в целую стень B
int a = 4;
int b = 7;

int DegreeNumbers(int a, int b)
{
    // return b == 0 ? 1 : DegreeNumbers(a, b - 1) * a; // аналогичная запись нижних строк
    if (b == 0) return 1;
    else return a * DegreeNumbers(a, b - 1);
}
Console.WriteLine(DegreeNumbers(a, b));

int PowerRecMath(int a, int n) // решение через математику
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(a, b));