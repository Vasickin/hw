// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Clear();
Console.Write($"Введите значение для координатной точки Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение для координатной точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введённое значение для Х,: {x}");
Console.WriteLine($"Введённое значение для y,: {y}");

int quadrant;

if(x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        quadrant = 1;
        Console.WriteLine($"{quadrant}-я координатная четверть плоскости");
    }

    else if(x < 0 && y > 0)
    {
        quadrant = 2;
        Console.WriteLine($"{quadrant}-я координатная четверть плоскости");
    }

    else if(x < 0 && y < 0)
    {
        quadrant = 3;
        Console.WriteLine($"{quadrant}-я координатная четверть плоскости");
    }

    else
    {
        quadrant = 4;
        Console.WriteLine($"{quadrant}-я координатная четверть плоскости");
    }
}

else
{
    Console.WriteLine($"Неверно введенные значения");
}


