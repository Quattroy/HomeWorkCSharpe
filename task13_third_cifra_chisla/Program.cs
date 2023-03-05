// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "");

int ThirdRunk(int number)
{
    while (number > 999)
    {
        number = number /10 %10;
    }
    return number;
}

bool ValidNumber(int number)
{
    if (number <100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

if (ValidNumber(number)) Console.WriteLine(ThirdRunk(number));

