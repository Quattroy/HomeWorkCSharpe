Console.Write("Введите число : ");
int Number = int.Parse(Console.ReadLine() ?? " ");
int x = 1;
while (x <= Number)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
        x++;
    }
