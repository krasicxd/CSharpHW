// Подсчет четных чисел до N


Console.WriteLine("Even digits count system:");

Console.Write("Type number to count evens up to:  ");

int n = Convert.ToInt32(Console.ReadLine () ?? "");
int count = 2;

Console.WriteLine("Even digits are: ");

while (count < n)
{
    Console.Write($" {count} ");
    count =count +2;  
}    
Console.WriteLine("");

