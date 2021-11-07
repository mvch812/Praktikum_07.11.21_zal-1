// Задача 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 

bool x = true;
bool y = false;
bool istin(bool x, bool y)
{
    return (!(x || y)) == (!x && !y);
}
Console.WriteLine($"Истинно ли утверждение, что ¬(X ⋁ Y) = ¬X ⋀ ¬Y? Ответ: {istin(x, y)}");
