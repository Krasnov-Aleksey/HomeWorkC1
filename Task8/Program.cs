Console.Clear();
Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=number1;i++)
{
    if (i % 2 == 0)
        Console.Write($" {i}");
}


