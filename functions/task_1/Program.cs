Console.Clear();

int max(int arg1, int arg2, int arg3)
{
    int Resalt = arg1;
    if (arg2 > Resalt)
    {
        Resalt = arg2;
    }
    if (arg3 > Resalt)
    {
        Resalt = arg3;
    }
    return Resalt;
}

int a1 = 43, b1 = 68, c1 = 567,
    a2 = 48, b2 = 83, c2 = 34,
    a3 = 51, b3 = 45, c3 = 26;

// int max1 = max(a1, b1, c1);
// int max2 = max(a2, b2, c2);
// int max3 = max(a3, b3, c3);

int total = max(
            max(a1, b1, c1),
            max(a2, b2, c2),
            max(a3, b3, c3));

Console.WriteLine($"{total}");

