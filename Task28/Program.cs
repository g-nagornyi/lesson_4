Console.Write("Введите любое число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

int ProductDigit(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
    {
        product = product * i;
    }
    return product;
}
int res = ProductDigit(number);

if (number <= 0)
{
    Console.WriteLine("Вы ввели некорректное число");
}
else
    Console.WriteLine(res);
