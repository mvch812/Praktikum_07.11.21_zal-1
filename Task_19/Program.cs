//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0 

int x = -90;
int y = -9;
int Chetvert(int x, int y)
{
    int nomerCh = 0;
    if (x > 0)
    {
        if (y > 0)
        {
            nomerCh = 1;
        }
        else
        {
            nomerCh = 4;
        }
    }
    else
    {
        if (y > 0)
        {
            nomerCh = 2;
        }
        else
        {
            nomerCh = 3;
        }
    }
    return nomerCh;
}
Console.WriteLine($"Координата ({x},{y}) находится в {Chetvert(x, y)}-й четверти");
