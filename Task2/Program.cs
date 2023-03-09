Console.Clear();
Console.Write("Введите 1-ое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    Console.Write($"max={number1}");
else
    Console.Write($"max={number2}");

