Console.Clear();
Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
double number2;
number2=number1%2;
if (number2 == 0)
    Console.Write("Число четное");
else
    Console.Write("Число нечетное");