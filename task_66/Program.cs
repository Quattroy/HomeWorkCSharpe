// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int M = GetNum("Введите натуральное значение M ", "Ошибка ввода!");
int N = GetNum("Введите натуральное значение N ", "Ошибка ввода!");

int result = GetResult(M, N);
Console.WriteLine($"M = {M}; N = {N} - > {result}");

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

int GetResult(int M, int N)
{
    if(M==N) return M;
    else if(M < N) return (M + GetResult(M+1, N));
    else return (N + GetResult(M,N+1));
}

    
