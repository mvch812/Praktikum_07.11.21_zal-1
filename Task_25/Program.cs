// 25. Найти сумму чисел от 1 до А
int i = new Random().Next(1, 100);

int summa(int i)
{
    int sum = 0;
    for (int x = 1; x <= i; x++)
    {
        sum = sum + x;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {i} = {summa(i)}");
