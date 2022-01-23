//Показать числа от -N до N 

int n = 20;
int[] array = new int[n * 2 + 1];
array[0] = -n;
for (int index = 1; index < array.Length; index++)
{
    array[index] = array[index - 1] + 1;
}

for (int index = 0; index < array.Length; index++)
{
    Console.Write($"{array[index]} ");
}
