//5.Найти максимальное из трех чисел 

Console.WriteLine("Введите число 1:");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3:");

int k = Convert.ToInt32(Console.ReadLine());

int[] array = { n, m, k };
int max = array[0];
for (int index = 0; index < array.Length; index++)
{
    if (array[index] > max)
    {
        max = array[index];
    }
}
Console.WriteLine($"Максимальное число:{max}");