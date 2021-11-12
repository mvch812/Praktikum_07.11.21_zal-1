// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными целыми числами от 0 до 9
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(0, 10);
        index++;
    }
}
int[] A = new int[12]; // задаем количество элементов массива A
Console.WriteLine("Случайный массив:");

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
FillArrayA(A);
PrintArray(A);

int summPositiv(int[] A)
{
    int sum = 0;
    for (int i = 0; i < A.Length; i++)
    {
        sum = sum + A[i];
    }
    return sum;
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива = {summPositiv(A)}");
