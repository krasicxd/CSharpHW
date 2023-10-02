// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSumm(int num)
{
    int summ = 0;
    while (num != 0) 
    {
        summ += num % 10;
        num /= 10;
    }
    if (summ < 0)
        summ = summ * (-1);
    return summ;
}

Console.WriteLine("Type number to get the digit summ:");
int result = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Summ of the digits is: {DigitSumm(result)}");
