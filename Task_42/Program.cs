// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Вводите числа, по завершении введите !:");


int[] CreateArray(int size)                    // функция для создания массива (резервирования памяти) размерностью size
{
    return new int[size];
}

int i = 0;
void FillArray(int[] A)
{
    string w = string.Empty;
    while (w != "!")
    {
        w = Console.ReadLine();
        if (w != "!")
        {
            A[i] = Convert.ToInt32(w);
            i++;
        }
    }
}


int[] A = CreateArray(10000); // поскольку не знаем сколько чисел введет пользователь, задаем 10000 элементов
FillArray(A); // заполняем массив
Array.Resize(ref A, i); // исключаем лишние нули массива

int CountPositive(int[] A)
{
    int count = 0;
    int l = A.Length;
    for (i = 0; i < l; i++)
    {
        if (A[i] > 0) count++;
    }
    return count;
}

// string PrintArray(int[] A)                  // функция для вывода массива на экран
// {
//     int count = A.Length;
//     string print = String.Empty;                  // изначально присваиваем строковой переменной, которую будем выводить в консоль пустую строку
//     for (int i = 0; i < count; i++)
//     {
//         print += $"{A[i]} ";                  // в строковую переменную записываем i-й элемент массива 
//     }
//     return print;
// }

// Console.WriteLine(PrintArray(A));
Console.WriteLine($"Вы ввели {CountPositive(A)} чисел больше 0");
