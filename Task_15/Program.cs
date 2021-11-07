//Задача 15: Дано число. Проверить кратно ли оно 7 и 23 

int i = new Random().Next(-100, 100);

bool Kratno(int numb)
{
    return numb % 7 == 0 && numb % 23 == 0;
}
Console.WriteLine($"Число {i} кратно 7 и 23? Ответ: {Kratno(i)}");

