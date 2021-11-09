// 39.Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от -10 до 10
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(-10, 10);
        index++;
    }
}
int[] A = new int[17]; // задаем количество элементов массива A
Console.WriteLine("Случайный массив:");
FillArrayA(A);

PrintArray(A);

void PrintArray(int[] A) // Метод, печатающий массив A  
{
    int index = 0;
    while (index < A.Length)
    {
        {
            Console.Write($"{A[index]} ");
        }
        index++;
    }
}

Console.WriteLine();

void Proizv(int[] A) // Метод, подсчитывающий произведение пар чисел в массиве
{
    int cur = 0;
    for (int x = 0; x <= 6; x++)
    {
        cur = A[(A.Length - x - 1)] * A[x];
        Console.WriteLine($"Произведение {x+1}-й пары чисел массива (первый-последний) равно: {cur}");
    }
}

Proizv(A);