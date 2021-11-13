//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0 

int x = -90;
int y = -9;
int Chetvert(int x, int y)
{
    if (x > 0)
    {
        if (y > 0) return 1;
        else return 4;
    }
    else
    {
        if (y > 0) return 2;
        else return 3;
    }
}
Console.WriteLine($"Координата ({x},{y}) находится в {Chetvert(x, y)}-й четверти");
