// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// y = k1*x + b1
// y = k2*x + b2
// if k1=k2 && b1=b2 то это одна и та же прямая
// if k1=k2 && b1!=b2 то прямые параллельны, точек пересечения нет
// else if k1!=k2    x=(b2-b1)/(k1-k2)     y=(b2*k1 - b1*k2)/(k1-k2)

Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double PointX(double k1, double b1, double k2, double b2)
{
    double x;
    return x = (b2 - b1) / (k1 - k2);
}

double PointY(double k1, double x, double b1)
{
    double y;
    return y = (b2 * k1 - b1 * k2) / (k1 - k2);
}

Console.WriteLine($"Точка пересечения прямых y = {k1} * x + {b1} и y = {k2} * x + {b2} имеет координаты: ({PointX(k1, b1, k2, b2)}, {PointY(k1, PointX(k1, b1, k2, b2), b1)})");

(double x, double y) CrossPoints(double k1, double b1, double k2, double b2)      //Второй способ - метод для нахождения точек пересечения прямых через кортеж
{
    if ((k1 == k2) && (b1 == b2)) return (double.PositiveInfinity, double.PositiveInfinity);   // точек бесконечно, т.к. это одна и та же прямая
    else if ((k1 == k2) && (b1 != b2)) return (double.NaN, double.NaN);       // точек пересечения нет
    else
    {
        double x = (b2 - b1) / (k1 - k2);         // x = (b2 - b1) / (k1 - k2)
        double y = (b2 * k1 - b1 * k2) / (k1 - k2);      // y = (b2*k1 - b1*k2) / (k1 - k2)
        return (x, y);
    }
}

Console.WriteLine(CrossPoints(k1, b1, k2, b2));   // вызываем метод расчета точки пересечения прямых