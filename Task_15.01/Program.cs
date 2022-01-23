// 15.	Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число:");

int n = Convert.ToInt32(Console.ReadLine());

int razryadnost(int n)
{
    int razr = 0;
    int s = Math.Abs(n);
    while (s >= 1)
    {
        s = s / 10;
        razr++;
    }
    return razr;
}

if (razryadnost(n) < 3)
{
    Console.WriteLine("В указанном числе нет третьей цифры слева");
}
else
{
    int m = (Math.Abs(n)/ Convert.ToInt32(Math.Pow(10, razryadnost(n) - 3))) % 10;
    Console.WriteLine($"Третья циффра заданного числа слева: {m}");
}

// Читерский способ решения задачи
Console.WriteLine("Введите целое число:");             // Выводим на экран приглашение ко вводу
string numb = Console.ReadLine();
if (numb.Length < 3)                                   // Если число меньше содержит меньше трёх цифр
    Console.WriteLine($"Введённое число {numb} не содержит третью цифру");      // то выводим это сообщение
else                                                                            // иначе выводим сообщение ниже 
{
    if (numb[0] == '-')
    {
        Console.WriteLine($"В числе {numb} третья цифра слева равна {numb[3]}, а третья цифра справа равна {numb[numb.Length - 3]}");
    }
    else
    {
        Console.WriteLine($"В числе {numb} третья цифра слева равна {numb[2]}, а третья цифра справа равна {numb[numb.Length - 3]}");
    }
}