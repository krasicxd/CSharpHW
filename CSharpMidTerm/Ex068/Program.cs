// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkerManFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AkkerManFunc(m - 1, 1);
    else
        return AkkerManFunc(m - 1, AkkerManFunc(m, n - 1));
}
        

Console.WriteLine("AkerManFunc example");
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AkkerManFunc(m, n);

Console.WriteLine($"A(m = {m}, n = {n}) = {result}");


