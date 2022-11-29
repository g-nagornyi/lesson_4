Console.WriteLine("Введите любое число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое натуральное число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int power = 1;

int Power(int num1, int num2, int pow)
{
    for (int i = 1; i <= num2; i++)
    {
        pow = pow * num1;
    }
    return pow;
}
int res = Power(number1, number2, power);
if (number2 > 0)
{
    Console.WriteLine($"Число {number1} в степени {number2} равно: {res}");
}
else
{
    Console.WriteLine($"Число {number2} не является натуральным");
}