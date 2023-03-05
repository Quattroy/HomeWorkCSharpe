//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int N = InputNumber("Введите число: ");
int count = 1;
while (count <= N)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}

static int InputNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.Write(message);
            n = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных {exc.Message}");
        }
    }
    return n;
}

