// 46. Написать программу масштабирования фигуры (любой правильный многоугольник)
// необходимо на координатной плоскости задать точки вершин фигуры. 
// Сделать переменную, отвечающую за кратность увеличения/уменьшения.
// Решить какая точка будет центром масштабирования (середина фигуры или допустим 1 из ее вершин).
// Указать новые координаты вершин согласно магии масштабирования.

// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"



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