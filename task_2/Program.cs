Console.Write("Введите число: ");
string one = Console.ReadLine();
int first = Convert.ToInt32(one);

Console.Write("Введите ещё одно число: ");
string two = Console.ReadLine();
int second = Convert.ToInt32(two);

Console.Write("Введите ещё одно число: ");
string three = Console.ReadLine();
int third = Convert.ToInt32(three);

int max = first;

if (max < second)
{
    max = second;
}

if (max < third)
{
    max = third;
}
Console.WriteLine(max);
