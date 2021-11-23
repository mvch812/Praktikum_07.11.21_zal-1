// 45. Показать числа Фибоначчи

Console.WriteLine($"Последовательность Фебоначчи:");


void FillArrayA(long[] A) // Метод, заполняющий массив A числами Фибоначчи
{
    A[0] = 0;
    A[1] = 1;
    for (int index = 2; index < A.Length; index++)
    {
        A[index] = A[index - 1] + A[index - 2];
    }
}
long[] A = new long[50]; // задаем количество элементов массива A

FillArrayA(A);

void PrintArray(long[] A) // Метод, печатающий массив A  
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

DateTime dt = DateTime.Now; // записываем текущее время до выполнения метода
PrintArray(A);
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // считаем время выполнения операции в милисекундах

