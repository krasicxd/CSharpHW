// Нахождение максимального числа

Console.WriteLine("Finding most");

Console.Write("Type first num: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Type second num: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Type third num: ");

int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine($"The maximum number is {max}");
