// 62.	В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите размер массива:");

Console.WriteLine("количество строк:");
int arraySize0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов:");
int arraySize1 = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int arraySize0, int arraySize1, int minValue, int maxValue) // метод, создающий массив,
// заполненный случайными числами
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

(int minPositionLine, int minPositionColumn) FindMinimum(int[,] Array) // метод для поиска позиции минимального элемента
{
    int min = Array[0, 0];
    int minPositionLine = 0;
    int minPositionColumn = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] < min)
            {
                min = Array[i, j];
                minPositionLine = i;
                minPositionColumn = j;
            }
        }
    }
    return (minPositionLine, minPositionColumn);
}
var position = FindMinimum(Array);
// Console.WriteLine($"Минимальный элемент: {position.Item1}");
// Console.WriteLine($"Минимальный элемент: {position.Item2}");
Console.WriteLine($"Минимальный элемент массива: {Array[position.Item1, position.Item2]}");

int[,] CreateNewArray(int[,] Array, int minPositionLine, int minPositionColumn) // метод, создающий новый
// массив с удаленными строкой и столбцом
{
    int[,] Array2 = new int[Array.GetLength(0) - 1, Array.GetLength(1) - 1];
    int arr2index0 = 0;
    int arr2index1 = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (i != minPositionLine)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                if (j != minPositionColumn)
                {
                    Array2[arr2index0, arr2index1] = Array[i, j];
                    arr2index1++;
                }
            }
            arr2index1 = 0;
            arr2index0++;
        }
    }
    return Array2;
}

int[,] Array2 = CreateNewArray(Array, position.Item1, position.Item2);

Console.WriteLine("Массив с удаленными строкой и столбцом на пересечении которых расположен наименьший элемент:");
Console.Write(PrintArray(Array2));
