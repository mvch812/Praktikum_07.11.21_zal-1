// 49.	Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("введите размер массива (количество строк):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размер массива (количество столбцов):");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Array = new double[m, n]; // выделяем память под массив (вводим массив)

void fillArray(int m, int n, double[,] Array) // метод, заполняющий массив случайными числами
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().NextDouble() * 100 - 50; //параметр случайных чисел от.. до ..
        }
    }
}

fillArray(m, n, Array); // заполняем массив

string PrintArray(double[,] Array)  // метод печатающий массив в строковую переменную
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
Console.WriteLine($"Двумерный массив размером {m}*{n} заполненный случайными вещественными числами:");
Console.Write(PrintArray(Array)); // печатаем строковую переменную с массивом