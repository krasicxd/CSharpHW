// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SummNums(int m, int n)
{
    int summ = 0;
    for (int i = m; i <= n; i++)
    {
        summ += i;
    }
    Console.Write($"{summ} "); 
}

Console.Write("Type M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Type N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"The summ of digits in range between {m} and {n} is: ");

SummNums(m,n);