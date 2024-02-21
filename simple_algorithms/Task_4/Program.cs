// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.Clear();

Console.Write($"Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine($"{num}");
}
else
{
    Console.WriteLine("Не корректно введённое число");
}

string numberString = num.ToString();

               for (int i = 0; i < numberString.Length; i++)
        {
            Console.Write(numberString[i]);

            if (i != numberString.Length - 1)
            {
                Console.Write(", ");
            }
        }



