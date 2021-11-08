//Задача 22. Найти расстояние между точками в пространстве 2D/3D

//Расчет расстояния для двухмерного пространства:

double x1 = 1;
double y1 = 3;
double x2 = -3;
double y2 = -1;

double Rasst2D(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((Math.Abs(x2 - x1)), 2) + Math.Pow((Math.Abs(y2 - y1)), 2));
}
Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) в пространстве 2D равно: {Rasst2D(x1, y1, x2, y2)}");

//Расчет расстояния для трехмерного пространства:

double z2 = -98;
double z1 = 87;
double Rasst3D(double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((Math.Abs(x2 - x1)), 2) + Math.Pow((Math.Abs(y2 - y1)), 2) + Math.Pow((Math.Abs(z2 - z1)), 2));
}
Console.WriteLine($"Расстояние между точками ({x1},{y1},{z1}), ({x2},{y2},{z2}) в пространстве 3D равно: {Rasst3D(x1, y1, x2, y2, z1, z2)}");