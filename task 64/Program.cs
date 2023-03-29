// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int N = GetNum("Введите натуральное значение N ", "Ошибка ввода!");
string result = GetResult(N);
Console.WriteLine($"N = {N} - > {result}");

///////////////////////////////////////////////

int GetNum(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}

string GetResult(int N)
{

    if(N == 1) return $"{N} ";
    return ($"{N} " + GetResult(N-1));
}
    
