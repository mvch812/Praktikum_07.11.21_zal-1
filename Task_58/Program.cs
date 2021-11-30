// 58.	Написать программу, которая в двумерном массиве заменяет строки на столбцы (транспонирование)

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

int[,] Transponir(int[,] Array)
{
    int[,] Array2 = new int[Array.GetLength(1), Array.GetLength(0)];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array2[j, i] = Array[i, j];
        }
    }
    return Array2;
}
Console.WriteLine("Транспонированный массив:");
Console.Write(PrintArray(Transponir(Array)));