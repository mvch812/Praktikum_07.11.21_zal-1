// 34. Написать программу замены элементов массива на противоположные (по знаку)

int[] CreateArray(int size)                    // функция для создания массива (резервирования памяти) размерностью size
{
    return new int[size];
}

void FillArray(int[] array, int minValue, int maxValue)     // функция заполнения массива значениями от minValue до maxValue
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);   // заполняем случайными числами от minValue до maxValue
    }
}

string PrintArray(int[] array)                  // функция для вывода массива на экран
{
    int count = array.Length;
    string print = String.Empty;                  // изначально присваиваем строковой переменной, которую будем выводить в консоль пустую строку
    for (int i = 0; i < count; i++)
    {
        print += $"{array[i]} ";                  // в строковую переменную записываем i-й элемент массива 
    }
    return print;
}

void ReplaceArray(int[] array)                            // функция для замены знака элемента массива на противоположный
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = -1 * array[i];
    }
}

Console.Clear();
int[] AR = CreateArray(30);                    // создаем массив из 30 элементов
FillArray(AR, -100, 100);                          // заполняем массив случайными числами от -100 до 100
Console.WriteLine("Случайный массив:");
Console.WriteLine(PrintArray(AR));             // выводим исходный массив на экран
ReplaceArray(AR);                              // заменяем элементы в массиве на противоположные
Console.WriteLine("Массив с элементами, замененными на противоположные:");
Console.WriteLine(PrintArray(AR));             // выводим измененный массив на экран