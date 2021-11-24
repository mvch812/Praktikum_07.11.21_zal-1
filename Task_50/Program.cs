// 50.	В двумерном массиве n×k заменить четные элементы на противоположные

Console.WriteLine("введите размер массива (количество строк):");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размер массива (количество столбцов):");
int k = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[n, k]; // выделяем память под массив (вводим массив)

void fillArray(int[,] Array) // метод, заполняющий массив случайными числами
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-10, 10); //параметр случайных чисел от.. до ..
        }
    }
}

fillArray(Array); // заполняем массив

string PrintArray(int[,] Array)  // метод печатающий массив в строковую переменную
{
    string print = string.Empty;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            print = print + Array[i, j] + ' ';
        }
        print = print + '\n';
    }
    return print;
}

Console.WriteLine();
Console.WriteLine($"Двумерный массив размером {n}*{k} заполненный целыми числами:");
Console.Write(PrintArray(Array)); // печатаем строковую переменную с массивом

void replacement1(int[,] Array) // 
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] % 2 == 0) Array[i, j] = -Array[i, j];
        }
    }
}
replacement1(Array);
Console.WriteLine();
Console.WriteLine($"Двумерный массив размером {n}*{k} c замененными четными элементами на противоположные:");
Console.Write(PrintArray(Array)); // печатаем строковую переменную с массивом

