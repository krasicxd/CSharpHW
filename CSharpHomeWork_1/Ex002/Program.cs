// more or less

Console.WriteLine("More or Less");

Console.Write("Type first num: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Type second num: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2){
    Console.WriteLine($"{num1} more than {num2}");
}
if (num1 == num2){
    Console.WriteLine($"Numbers {num1} and {num2} are equal");
}
else{
    Console.WriteLine($"{num1} less than {num2}");
}