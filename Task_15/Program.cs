//Задача: Дано число. Проверить кратно ли оно 7 и 23 

// int i = 7;
// bool Krat(int numb)
// {
//     bool n = false;
//     if (numb % 7 == 0)
//     {
//         if (numb % 23 == 0)
//         {
//             n = true;
//         };
//     }
//     return n;

// }
// if (Krat(i) == true)
// {
//     Console.WriteLine($"Число {i} кратно 7 и 23");
// }
// else
//     Console.WriteLine($"Число {i} не кратно 7 и 23");


// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// 

//Задача: По двум заданным числам проверять является ли одно квадратом другого

// double i = 4;
// double k = 16;


// bool sqrt1(double i, double k)
// {
//     return i == Math.Pow(k, 2);
// }

// bool sqrt2(double i, double k)
// {
//     return k == Math.Pow(i, 2);
// }

// Console.WriteLine($"Первое число {i} квадрат второго числа {k} - {sqrt1(i, k)}");
// Console.WriteLine($"Второе число {k} квадрат первого числа {i} - {sqrt2(i, k)}");





//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0 

int x = 90;
int y = -9;
int Chetvert(int x, int y)
{
    int nomerCh = 0;
    if (x > 0)
    {
        if (y > 0)
        {
            nomerCh = 1;
        }
        else
        {
            nomerCh = 4;
        }
    }
    else
    {
        if (y > 0)
        {
            nomerCh = 2;
        }
        else
        {
            nomerCh = 3;
        }
    }
    return nomerCh;
}
Console.WriteLine($"Координата ({x},{y}) находится в {Chetvert(x, y)}-й четверти");
