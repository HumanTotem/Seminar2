Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 100)
{
    Console.WriteLine("Третьего числа нет");
}
else
{
    while (number1 > 999);
    {
        number1 = number1/10;
    }
    number1 = number1 % 100;
    Console.WriteLine($"{number1}");
}