// 71.	Написать программу вычисления функции Аккермана

// Функция Аккермана — простой пример всюду определённой вычислимой функции,
// которая не является примитивно рекурсивной. Она принимает два неотрицательных
// целых числа в качестве параметров и возвращает натуральное число. Эта функция растёт очень быстро,
// например, число A(4,4) настолько велико, что количество цифр в порядке этого числа многократно превосходит 
// количество атомов в наблюдаемой части Вселенной.

Console.WriteLine("Введите неотрицательное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n:");
int n = Convert.ToInt32(Console.ReadLine());


int AkkermanFunction(int m, int n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}

Console.WriteLine(AkkermanFunction(m, n));