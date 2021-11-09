// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.WriteLine();
void FillArrayA(double[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от -20 до 20
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().NextDouble() * 40 - 20;
        index++;
    }
}
double[] A = new double[17]; // задаем количество элементов массива A
Console.WriteLine("Случайный массив:");
FillArrayA(A);

PrintArray(A);

void PrintArray(double[] A) // Метод, печатающий массив A  
{
    int index = 0;
    while (index < A.Length)
    {
        {
            Console.WriteLine($"{A[index]} ");
        }
        index++;
    }
}

Console.WriteLine();

double Min(double[] A) // Метод поиска минимального элемента массива
{
    double min = A[0];
    for (int x = 0; x < A.Length; x++)
    {
        if (A[x] < min)
        {
            min = A[x];
        }
    }
    return min;
}

double Max(double[] A) // Метод поиска максимального элемента массива
{
    double max = A[0];
    for (int x = 0; x < A.Length; x++)
    {
        if (A[x] > max)
        {
            max = A[x];
        }
    }
    return max;
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Max(A) - Min(A)}");
