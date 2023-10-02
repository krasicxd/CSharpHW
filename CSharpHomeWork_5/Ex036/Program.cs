// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] CreateArray()
{
    int size = new Random().Next(1,10);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    };
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {     
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

void OddSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            summ = summ + array[i];
        }
    }
    Console.WriteLine(summ);
}

Console.WriteLine();

int [] newArray = CreateArray();

Console.Write("Out of: ");

PrintArray(newArray);

Console.WriteLine();

Console.Write("Summ for the odd nums is: ");

OddSumm(newArray);

Console.WriteLine();




