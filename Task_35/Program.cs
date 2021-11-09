// 35. Определить, присутствует ли в заданном массиве, некоторое число 

Console.WriteLine();
void FillArrayA(int[] A) // Метод, заполняющий массив A случайными целыми числами от -100 до 100
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(-100, 100);
        index++;
    }
}
int[] A = new int[20]; // задаем количество элементов массива A
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

Console.WriteLine();
Console.WriteLine("Введите число для поиска в массиве:");

int i = Convert.ToInt32(Console.ReadLine());

bool FindElement(int i, int[] A)
{
    bool ff = false;
    for (int x = 0; x < A.Length; x++)
    {
        if (A[x] == i)
        {
            ff = true;
        }
    }
    return ff;
}

if (FindElement(i, A) == true)
{
    Console.WriteLine($"Число {i} присутствует в массиве.");
}
else
{
    Console.WriteLine($"Число {i} отсутствует в массиве.");
}