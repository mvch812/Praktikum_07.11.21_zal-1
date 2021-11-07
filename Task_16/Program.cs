//Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным  

int i = new Random().Next(1, 8);
bool weekEnd(int numb)
{
    return numb == 6 | numb == 7;
}
Console.WriteLine($"{i}-й день недели выходной? Ответ: {weekEnd(i)}");
