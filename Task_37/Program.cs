// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] 

Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от -100 до 1000
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(-100, 1000);
        index++;
    }
}
int[] A = new int[123];
Console.WriteLine("Случайный массив:");
FillArrayA(A);

int m = 10;
int k = 99;

PrintArray(A);

void PrintArray(int[] A) // Метод, печатающий массив A и выделяющий звездочкой элементы из отрезка [10,99] 
{
    int index = 0;
    while (index < A.Length)
    {
        if (A[index] >= m && A[index] <= k)
        {
            Console.Write($"{A[index]}* ");
        }
        else
        {
            Console.Write($"{A[index]} ");
        }
        index++;
    }
}

int Count(int m, int k, int[] A) // Метод, подсчитывающий количество элементов массива А из отрезка [10,99] 
{
    int cur = 0;
    for (int x = 0; x < A.Length; x++)
    {

        if (A[x] >= m && A[x] <= k)
        {
            cur++;
        }
    }
    return cur;
}
Console.WriteLine();

Console.WriteLine($"Количество элементов массива из отрезка [{m},{k}]: {Count(m, k, A)}");