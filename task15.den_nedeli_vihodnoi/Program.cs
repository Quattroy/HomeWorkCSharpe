// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

bool IsWeekend(int day)
{
    if (day > 5)
    {
        
        return true;
    }
    return false;
}

bool IsDayOfWeek(int day)
{
    if(day >= 1 && day <= 7)
    {
        return true;
    }
    Console.WriteLine("это не день недели");
    return false;
}

Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine() ?? "");

if(IsDayOfWeek(day))
    if(IsWeekend(day))
    Console.WriteLine("День недели является выходным днем");
    else
    Console.WriteLine("День недели является будним днем");

