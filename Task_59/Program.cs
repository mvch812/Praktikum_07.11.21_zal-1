// 59.	В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер прямоугольной матрицы:");

Console.WriteLine("количество строк:");
int arraySize0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов:");
int arraySize1 = Convert.ToInt32(Console.ReadLine());
while (arraySize1 == arraySize0)
{
    Console.WriteLine("количество столбцов должно отличаться от количества строк, введите количество столбцов повторно:");
    arraySize1 = Convert.ToInt32(Console.ReadLine());
}

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

int MinSummLine(int[,] Array)
{
    int sum = 0;
    int linePosition = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        sum += Array[0, j];
    }
    int min = sum;

    for (int i = 1; i < Array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum += Array[i, j];
        }

        if (sum < min)
        {
            min = sum;
            linePosition = i;
        }
    }
    return linePosition;
}
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {MinSummLine(Array)}");
