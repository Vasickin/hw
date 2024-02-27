Console.Clear();

int[] arr = { 1, 2, 3, 4, 5, 666, 7, 8, 9 };

int max(int arg1, int arg2, int arg3)
{
    // int Resalt = arg1;
    // if (arg2 > Resalt)
    // {
    //     Resalt = arg2;
    // }
    // if (arg3 > Resalt)
    // {
    //     Resalt = arg3;
    // }
    // return Resalt;

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


int total = max(
    max(arr[0], arr[1], arr[2]),
    max(arr[3], arr[4], arr[5]),
    max(arr[6], arr[7], arr[8]));

Console.WriteLine($"{total}");

