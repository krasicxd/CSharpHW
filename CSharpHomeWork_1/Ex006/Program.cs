// Проверка числа на четность

Console.WriteLine("Even?");

Console.Write("Type your num: ");

int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0){
   Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}