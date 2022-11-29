Console.WriteLine("Введите любое число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
if (number > 0)
{
    int res = SumNumbers(number);
    Console.WriteLine(res);
}
else Console.WriteLine("Вы ввели некорректное число");
