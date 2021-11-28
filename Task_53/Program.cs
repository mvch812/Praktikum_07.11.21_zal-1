// 53.	В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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
            print = print + $"{Array[i, j],4} ";
        }
        print = print + '\n';
    }
    return print;
}

Console.WriteLine();
Console.WriteLine($"Двумерный массив размером {n}*{k} заполненный целыми числами:");
Console.Write(PrintArray(Array)); // печатаем строковую переменную с массивом

Console.WriteLine("Введите число, позицию которого в массиве хотите найти:");
int x = Convert.ToInt32(Console.ReadLine());

string PrintIndex(int[,] ArrayIn, int find)
{
    string position = string.Empty;
    for (int i = 0; i < ArrayIn.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayIn.GetLength(1); j++)
        {
            if (ArrayIn[i, j] == find) position += ($"[{i},{j}], ");
        }
    }
    if (position == string.Empty) return "В массиве нет таких элементов";
    else return position = "Введенному Вами числу соответствуют следующий элемент(ы) массива:" + position;
}
Console.WriteLine(PrintIndex(Array, x));
