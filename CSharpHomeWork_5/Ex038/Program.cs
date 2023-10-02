// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = {3.22, 4.2, 1.15, 77.15, 65.2};

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {     
        Console.Write($"{array[i]} ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
void SortArray(double[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        double temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
double GetMinMax(double[] array)
{
    double min = array[0];
    double max = array[4];
    double result = max - min;
    return result;
}

Console.WriteLine();
Console.Write("Within an array: ");
PrintArray(array);
Console.WriteLine();

Console.Write("Max and min elements found: ");
SortArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("The difference between elements is: ");
Console.WriteLine(GetMinMax(array));
Console.WriteLine();

