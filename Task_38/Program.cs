// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от -100 до 1000
{
    int length = A.Length;
    int index = 0;
    int summ = 0;
    while (index < length)
    {
        A[index] = new Random().Next(-100, 1000);
        summ = summ + A[index];
        index++;
    }
}
int[] A = new int[12]; // задаем количество элементов массива A
Console.WriteLine("Случайный массив:");
FillArrayA(A);

PrintArray(A);

void PrintArray(int[] A) // Метод, печатающий массив A  
{
    int index = 0;
    while (index < A.Length)
    {
        {
            Console.Write(A[index] + " ");
        }
        index++;
    }
}

int Count(int[] A) // Метод, подсчитывающий количество элементов массива А, стоящих на нечетной позиции
{
    int cur = 0;
    for (int x = 0; x < A.Length; x++)
    {

        if (x % 2 != 0)
        {
            cur = cur + A[x];
        }
    }
    return cur;
}
Console.WriteLine();

Console.WriteLine($"Cумма чисел массива, стоящих на нечетной позиции равна: {Count(A)}");

