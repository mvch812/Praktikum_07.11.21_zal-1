// 47. Написать программу копирования массива 

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



Console.Clear();
int[] arr1 = CreateArray(30);                    // создаем массив из 30 элементов
FillArray(arr1, -100, 100);                          // заполняем массив случайными числами от -100 до 100
Console.WriteLine("Случайный массив:");
Console.WriteLine(PrintArray(arr1));             // выводим исходный массив на экран

int[] arr2 = (int[])arr1.Clone(); // Копируем массив с помощью метода Clone()


Console.WriteLine("Копия массива способом Clone():");
Console.WriteLine(PrintArray(arr2));             // выводим копию массива на экран

int[] arr3 = CreateArray(arr1.Length);
Array.Copy(arr1, arr3, arr1.Length);// Копируем с помощью метода Copy()
Console.WriteLine("Копия массива способом Copy():");
Console.WriteLine(PrintArray(arr2));             // выводим копию массива на экран