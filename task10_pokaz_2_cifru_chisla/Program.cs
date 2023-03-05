// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine() ?? "");

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
    return;
}

int a = number / 10;
int b = a % 10;
Console.WriteLine($" вторая цифра числа {number} => {b}");



