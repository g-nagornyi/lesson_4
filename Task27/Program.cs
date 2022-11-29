Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0; 
int SumDigits(int num, int s)
{ 
    while (Math.Abs(num) > 0)
    {
        s = s + num % 10;
        num = num / 10;
    }
    return Math.Abs(s);
}
int res = SumDigits(number, sum);
Console.WriteLine(res);
