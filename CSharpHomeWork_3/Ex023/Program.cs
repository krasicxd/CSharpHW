//  Takes any number and gives back table of quaters from 1 to N;

void Cube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i*i*i} ");
    }
}

Console.WriteLine("Enter yout number: ");
int numb = Convert.ToInt32(Console.ReadLine());
if(numb < 0)
   numb *= (-1);
else if(numb ==0)
   Console.WriteLine("Wrong number");

Cube(numb);