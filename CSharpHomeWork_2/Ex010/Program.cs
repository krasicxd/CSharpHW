using System.Globalization;

void Extract2nd(int num)
{
    if(num>100 && num<999)
    {
       int mid_digit = (num / 10) % 10;
        Console.WriteLine($"Digit you're looking for is {mid_digit}");
    }
    else
    {
        Console.WriteLine("Good try, never again please");
    }
}

Console.WriteLine("Extracting second digit:");
Console.Write("Type your num:   ");

int middle = Convert.ToInt32(Console.ReadLine());

Extract2nd(middle);


