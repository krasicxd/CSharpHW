// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double CountDeg(double num1, double num2)
{
    if (num2 == 0)
        return 1;
    else if (num2 % 2 == 0)
        return CountDeg(num1 * num1, num2 / 2);
    else
        return num1 * CountDeg(num1, num2 - 1);
}


Console.WriteLine("Type your number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type your number for degree: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Answer is: ");
Console.WriteLine($"{CountDeg(a, b)}");