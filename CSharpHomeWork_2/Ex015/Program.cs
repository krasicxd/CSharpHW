// weekday check 


// void Week(int[] list)
// {
//     int length = list.Length;
//     int index = 0;
//     while (index < length)
//     {
//         list[index] = (1, 5);
//         index++;
//     }
// }

// void End(int[] list)
// {
//     int length = list.Length;
//     int index = 0;
//     while (index < length)
//     {
//         list[index] = (6, 7);
//         index++;
//     }
// }


void Week(int n)
{
    if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
{
   Console.WriteLine("No");
}
    else if (n == 6 || n == 7)
{
   Console.WriteLine("Yes");
}


// else if (n == 3){
//    Console.WriteLine("No");
//    }
// else if (n == 4){
//    Console.WriteLine("No");
//    }
// else if (n == 5){
//    Console.WriteLine("No");
//    }
// else if (n == 6){
//    Console.WriteLine("Yes");
//    }
// else if (n == 7){
//    Console.WriteLine("Yes");
// }

else
{
    Console.WriteLine("Not a weekday");
}
}



Console.WriteLine("Is that weekend?");

Console.Write("Type number:  ");

int res = Convert.ToInt32(Console.ReadLine());

Console.Write($"Answer will be ==> ");

Week(res);
