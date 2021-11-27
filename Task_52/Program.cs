// 52.	В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите размер массива:");

Console.WriteLine("количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов:");
int k = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[n, k]; // выделяем память под массив (вводим массив)

void fillArray(int[,] Array) // метод, заполняющий массив случайными числами
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-100, 100); //параметр случайных чисел от.. до ..
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

void replacementEven(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) Array[i, j] = Array[i, j] * Array[i, j];
        }
    }
}
replacementEven(Array);
Console.WriteLine();
Console.WriteLine($"Двумерный массив размером {n}*{k} заполненный целыми числами:");
Console.Write(PrintArray(Array)); // печатаем строковую переменную с массивом