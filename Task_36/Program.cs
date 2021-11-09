// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел 

Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными трехзначными целыми числами от 100 до 1000
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(100, 1000);
        index++;
    }
}
int[] A = new int[20];
Console.WriteLine("Случайный массив:");
FillArrayA(A);

PrintArray(A);

void PrintArray(int[] A) // Метод, печатающий массив A  
{
    int index = 0;
    while (index < A.Length)
    {
        Console.Write($"{A[index]} ");
        index++;
    }
}


int Count(int[] A) // Метод, подсчитывающий количество элементов массива А из отрезка [10,99] 
{
    int cur = 0;
    for (int x = 0; x < A.Length; x++)
    {
        if (A[x] % 2 != 0)
        {
            cur++;
        }
    }
    return cur;
}
Console.WriteLine();

Console.WriteLine($"Количество нечетных элементов массива: {Count(A)}");