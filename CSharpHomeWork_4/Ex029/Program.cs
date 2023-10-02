// Напишите программу, которая задаёт массив до 10 элементов (максимальный элемент 100) и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray()
{
    int size = new Random().Next(1,11);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,101);
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

Console.WriteLine();
PrintArray(CreateRandomArray());
Console.WriteLine();
Console.WriteLine();
