// 61.	Найти произведение двух матриц 
Console.WriteLine("Введите размер матриц (количество строк и столбцов):");

int arraySize0 = Convert.ToInt32(Console.ReadLine());

int arraySize1 = arraySize0;

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

int[,] ArrayA = CreateArray(arraySize0, arraySize1, -5, 5);

int[,] ArrayB = CreateArray(arraySize0, arraySize1, -10, 10);

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
Console.WriteLine($"Двумерный массив A:");
Console.Write(PrintArray(ArrayA)); // печатаем строковую переменную с массивом
Console.WriteLine($"Двумерный массив B:");
Console.Write(PrintArray(ArrayB)); // печатаем строковую переменную с массивом

int[,] ProductOfNumbers(int[,] Array1, int[,] Array2)
{
    int[,] Array3 = new int[Array1.GetLength(1), Array1.GetLength(0)];

    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            Array3[i, j] = Array1[i, j] * Array2[i, j];
        }
    }
    return Array3;
}
Console.WriteLine("Результат перемножения матриц:");
Console.Write(PrintArray(ProductOfNumbers(ArrayA, ArrayB)));