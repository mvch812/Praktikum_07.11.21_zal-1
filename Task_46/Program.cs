// 46. Написать программу масштабирования фигуры (любой правильный многоугольник)
// необходимо на координатной плоскости задать точки вершин фигуры. 
// Сделать переменную, отвечающую за кратность увеличения/уменьшения.
// Решить какая точка будет центром масштабирования (середина фигуры или допустим 1 из ее вершин).
// Указать новые координаты вершин согласно магии масштабирования.



Console.WriteLine("Введите координаты вершин правильного многоугольника в формате (x1;y1), (x2;y2)...:");
string text = Console.ReadLine();
// string[] = new string[text];
// string.Join(',',array)


char[] delimiterChars = { ' ', ',', '.', '(', ')', ';' };

string[] num = text.Split(delimiterChars);

int[] numbers = new int[num.Length];

int j = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] != string.Empty)
    {
        numbers[j] = Convert.ToInt32(num[i]);
        j++;
    }
}

Array.Resize(ref numbers, j);// отбрасываем лишние элементы

string PrintArray(int[] array)                  // функция для вывода массива на экран
{
    int count = array.Length;
    string print = String.Empty;                  // изначально присваиваем строковой переменной, которую будем выводить в консоль пустую строку
    for (int i = 0; i < count; i++)
    {
        print += $"{array[i]} ";                  // в строковую переменную записываем i-й элемент массива 
    }
    return print;
}
Console.WriteLine();
Console.WriteLine(PrintArray(numbers));

int l = numbers.Length / 2;
int[,] position = new int[l, 2];
void ArrayCoordin(int[] numbers, int[,] position)
{
    int k = 0;
    for (int i = 0; i < l; i++)
    {
        for (int s = 0; s < 2; s++)
        {
            position[i, s] = numbers[k];
            k++;
        }
    }
}


void PrintArray2(int[,] AR)
{
    for (int i = 0; i < AR.GetLength(0); i++)
    {
        for (int j = 0; j < AR.GetLength(1); j++)
        {
            Console.Write($"{AR[i, j]} ");
        }
        Console.WriteLine();
    }
}
ArrayCoordin(numbers, position);
PrintArray2(position);