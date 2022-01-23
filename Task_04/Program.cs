//4. По заданному номеру дня недели вывести его название

void WeekDay(int dayNumber)
{
    String[] week = { "Мonday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    Console.WriteLine(week[dayNumber - 1]);

}


Console.WriteLine("Введите день недели:");

int n = Convert.ToInt32(Console.ReadLine());
if (n <= 7 && n >= 1)
{
    WeekDay(n);
}
else
{
    Console.WriteLine("Вы ошиблись, в неделе только 7 дней :)");
}
