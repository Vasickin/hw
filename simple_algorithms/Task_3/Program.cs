// Напишите программу, которая принимает на вход целое число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

Console.Clear();

Console.Write("Ведите целое число из отрезка [10, 99]: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 10 && num < 100)
{
    int num1 = num / 10;
    int num2 = num % 10;

    if(num1 > num2)
    {
        Console.WriteLine($"{num1} наибольшая цифра из введённого целого числа");
    }

    else
    {
        Console.WriteLine($"{num2} наибольшая цифра из введённого целого числа");
    }
}

else
{
    Console.WriteLine($"Не верно введённое число");
}