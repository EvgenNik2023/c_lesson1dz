Console.Write("Введите число: ");
string digit = Console.ReadLine();
int N = Convert.ToInt32(digit);

int count = 2;

while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count++;
}
