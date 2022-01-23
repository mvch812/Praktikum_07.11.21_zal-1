//20. Задать номер четверти, показать диапазоны для возможных координат
int b = new Random().Next(1, 5);
string Range(int b)
{
    if (b == 1)
    {
        return $"Диапазон по Х (от 0 до {double.MaxValue}), диапазон по Y (от 0 до {double.MaxValue})";
    }
    if (b == 2)
    {
        return $"Диапазон по Х (от {double.MinValue} до 0), диапазон по Y (от 0 до {double.MaxValue})";
    }
    if (b == 3)
    {
        return $"Диапазон по Х (от {double.MinValue} до 0), диапазон по Y (от {double.MinValue} до 0)";
    }
    if (b == 4)
    {
        return $"Диапазон по Х (от 0 до {double.MaxValue}), диапазон по Y (от {double.MinValue} до 0)";
    }
    else return $"Номер четверти задан неверно!";
}
Console.WriteLine($"Диапазон возможных координат для {b} четверти: {Range(b)}");