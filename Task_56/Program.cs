// 56.	Написать программу, которая обменивает элементы первой строки и последней строки

Console.WriteLine("Введите размер массива:");

Console.WriteLine("количество строк:");
int arraySize0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов:");
int arraySize1 = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int arraySize0, int arraySize1, int minValue, int maxValue) // метод, создающий массив, заполненный случайными числами
{
    int[,] Array = new int[arraySize0, arraySize1];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(minValue, maxValue); //параметр случайных чисел от.. до ..
        }
    }
    return Array;
}

int[,] Array = CreateArray(arraySize0, arraySize1, -100, 100);

string PrintArray(int[,] Array)  // метод печатающий массив в строковую переменную
{
    string print = string.Empty;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            print = print + $"{Array[i, j],4} ";
        }
        print = print + '\n';
    }
    return print;
}

Console.WriteLine();
Console.WriteLine($"Двумерный массив размером {arraySize0}*{arraySize1} заполненный целыми числами:");
Console.Write(PrintArray(Array)); // печатаем строковую переменную с массивом

int[,] ReverseArray(int[,] Array) // метод, производящий замену элементов первой строки и последней строки
{
    int bufer = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {

        bufer = Array[0, j];
        Array[0, j] = Array[Array.GetLength(0) - 1, j];
        Array[Array.GetLength(0) - 1, j] = bufer;
    }
    return Array;
}
int[,] Array2 = ReverseArray(Array);

Console.WriteLine($"Новый массив с произведенными заменами:");
Console.Write(PrintArray(Array2));