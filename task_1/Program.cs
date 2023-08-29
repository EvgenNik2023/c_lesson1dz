
Console.Write("Введите число: ");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
Console.Write("Введите ещё одно число: ");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);
if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
}
else if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("max = " + number2);
}

