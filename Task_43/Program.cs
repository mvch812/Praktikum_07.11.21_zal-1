// 43. Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите десятичное число:");

int i = Convert.ToInt32(Console.ReadLine());

//int i = 123;
int count = 0;
void FillArrayA(int i, long[] A) // Метод, заполняющий массив A
{
    for (int index = 0; i >= 1; index++)
    {
        A[index] = i % 2;
        i = i / 2;
        count++;
    }
}
long[] A = new long[10000]; // задаем количество элементов массива A

FillArrayA(i, A);

Array.Resize(ref A, count);// отбрасываем лишние элементы

long[] B = new long[A.Length]; //в массив B записываем массив А наоборот
void ArrayReverse(long[] A)
{
    for (int index = 0; index < A.Length; index++)
    {
        B[A.Length - 1 - index] = A[index];
    }
}

ArrayReverse(A);
Console.WriteLine($"Десятичное число {i} в двоичной системе:");
void PrintArray(long[] B) // Метод, печатающий массив B  
{
    int index = 0;
    while (index < B.Length)
    {
        {
            Console.Write($"{B[index]} ");
        }
        index++;
    }
}
PrintArray(B);