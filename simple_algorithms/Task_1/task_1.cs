 //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write($"Введите любое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Введённое число: {num}");

        if(num % 7 == 0 && num % 23 == 0)
        {
            Console.WriteLine($"Число {num} кратно числу 7 и 23");
        }
        else if(num % 7 != 0 && num % 7 < 0)
        {
            Console.WriteLine($"Число {num} не кратно 7, но кратно 23");
        }
        else if(num % 23 != 0 && num % 23 < 0)
        {
            Console.WriteLine($"Число {num} не кратно 23, но кратно 7");
        }
        else
        {
            Console.WriteLine($"Число {num} не кратно числу 7 и 23! \n Остаток от деления на 7 = {num % 7} \n Остаток от деления на 23 = {num % 23}");
        }
    }
}