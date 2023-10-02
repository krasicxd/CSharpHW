// Takes coord for 2 points and finds distance between em using math formula

double Dist(int x1, int y1, int x2, int y2, int z1, int z2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;
    int q = x*x + y*y + z*z;
    double res = Math.Round(Math.Sqrt(q),2);
    return res;
}

Console.WriteLine("Enter x1 point:  ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y1 point:  ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z1 point:  ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter x2 point:  ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y2 point:  ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z2 point:  ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance between points is {Dist(x1, y1, x2, y2, z1, z2)}");
