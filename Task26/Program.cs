Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int AmountDigits(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count == 0 ? 1 : count;
}
int res = AmountDigits(number);
Console.WriteLine(res);