// 12.	Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int MaxNumber(int n)
{
    int n1 = n / 10;
    int n2 = n % 10;
    if (n1 > n2)

        return n1;
    else
        return n2;

}

int InputNumber()
{
    Console.WriteLine("Введите двузначное число:");
    while (true)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 9 && n < 100) return n;
        else Console.WriteLine("Двузначное число не введено. Повторите ввод:");
    }
}
int m = InputNumber();

Console.WriteLine($"Наибольшая цифра двузначного числа:{MaxNumber(m)}");

