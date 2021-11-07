//Задача 22. Найти расстояние между точками в пространстве 2D/3D

double x1 = 98;
double y1 = 23;
double x2 = 8;
double y2 = 130;

// double r = Math.Pow(Math.Abs(x2 - x1), 2);
// double p = Math.Pow(Math.Abs(y2 - y1), 2);
// Console.WriteLine(Math.Pow(r,2));
// Console.WriteLine(Math.Pow(p,2));
// double rq= Math.Sqrt(Math.Pow(r,2)+Math.Pow(p,2));
// Console.WriteLine(rq);

// double Rasst(double x1, double y1, double x2, double y2);
// {
//     double r = Math.Sqrt(Math.Pow((Math.Abs(x2 - x1)), 2) + Math.Pow((Math.Abs(y2 - y1)), 2));
//     return r;
// }
// Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) в пространстве 2D равно: {Rasst(x1, y1, x2, y2)}");

double r = Math.Round(Math.Sqrt(Math.Pow((Math.Abs(x2 - x1)), 2) + Math.Pow((Math.Abs(y2 - y1)), 2)));
Console.WriteLine(r);
// int x1 = 98;
// int y1 = 23;
// int x2 = 8;
// int y2 = 130;

// int Rasst(int x1, int y1, int x2, int y2);
// {
//     return Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2));
// }
// Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) в пространстве 2D равно: {Rasst(x1, y1, x2, y2)}");