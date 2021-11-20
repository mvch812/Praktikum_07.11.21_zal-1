// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 


Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от 0 до 1
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(0, 2);
        index++;
    }
}
int[] A = new int[8]; // задаем количество элементов массива A
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
