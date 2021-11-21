// 42. Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите числа через запятую:");
string text = Console.ReadLine();
// string[] = new string[text];
// string.Join(',',array)


char[] delimiterChars = { ' ', ',', '.' };

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


int CountPositive(int[] A)
{
    int count = 0;
    int l = A.Length;
    for (int i = 0; i < l; i++)
    {
        if (A[i] > 0) count++;
    }
    return count;
}
Console.WriteLine($"Вы ввели {CountPositive(numbers)} чисел больше 0");