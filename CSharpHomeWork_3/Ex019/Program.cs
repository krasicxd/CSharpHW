// no string, no massives just do it

int Main(int n)
{ 
    int reverse = 0;
        while (n > 0)
        {
            reverse = reverse * 10 + n % 10;
            n /= 10;
        }
        return reverse;
}

Console.WriteLine("Enter your number: ");

int result = Convert.ToInt32(Console.ReadLine());

    if (result < 9999 || result > 99999)
    {
        Console.WriteLine("Wrong number");
    }
    else
   {
    Main(result);
   }

   
    int result1 = Main(result);

    if (result == result1)
    {
        Console.WriteLine($"The number {result} is palindrome");
    }
    else if (result != result1)
    {
        Console.WriteLine($"The number {result} is not palindrome");
    }



