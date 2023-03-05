// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (читается одинаково с разных сторон).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();

int number = InputNumber("Введите пятизначное число: ");
proverkaZnach(number);
proverkaPalindrom(number);


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

static void proverkaZnach(int number)
{
    if (number > 0 && number < 100000 && number / 10000 != 0)
    {
        Console.WriteLine("Введено корректное значение числа");

    }
    else
    {
        Console.WriteLine("Ошибка! Введено не 5ти значное число");

    }

}

static void proverkaPalindrom(int number)
{
    if ((number / 10000 == number % 10) && (number / 1000 % 10 == number % 100 / 10))
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число НЕ является палиндромом");


}
