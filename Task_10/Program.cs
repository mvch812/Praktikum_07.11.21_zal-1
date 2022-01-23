//10: Показать последнюю цифру трёхзначного числа

int LastNumber(int n)
{
    return n % 10;
}

int InputNumber()
{
    Console.WriteLine("Введите трехзначное число:");
    while (true)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 99 && n < 1000) return n;
        else Console.WriteLine("Трехзначное число не введено. Повторите ввод:");
    }
}
int m = InputNumber();

Console.WriteLine($"Последняя цифра введенного числа:{LastNumber(m)}");

