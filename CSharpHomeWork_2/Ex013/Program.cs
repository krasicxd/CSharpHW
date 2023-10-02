// Нахождение второго числа в трехзначном

using System.Globalization;

void Range100(int num)
{
    if(num>100 && num<999)
    {
        int mid_digit = num % 10;
        Console.WriteLine($"Digit you're looking for is {mid_digit}");
    }
}
void RangeOver(int num)
{
    if(num>999)
    {
    // int third_digit = (num / 10) % 10;
    int third_digit = int.Parse(num.ToString()[2].ToString());
    Console.WriteLine($"Digit you're looking for is {third_digit}");
    }
}
void RangeLess(int num)
{
    if(num<100)
{
    Console.WriteLine("There is no third number");
}
}

Console.WriteLine("Extracting second digit:");
Console.Write("Type your num:   ");

int num = Convert.ToInt32(Console.ReadLine());

Range100(num);
RangeOver(num);
RangeLess(num);

