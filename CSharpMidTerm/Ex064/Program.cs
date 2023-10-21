// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers(int n, int m)
{
    int max = Math.Max(m,n);
    int min = Math.Min(m,n);
    if (max != min) 
    {
        ShowNumbers(max, min + 1);
    }
    Console.Write($"{min}, "); // При использовании "\b" или var/string применяется к каждому значению n;
}
Console.Write("Type your number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNumbers(num, 1); 

