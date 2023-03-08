// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
int numA = GetNumberFromUserA("Введите целое число А: ", "Ошибка ввода!");
int numB = GetNumberFromUserB("Введите целое число B: ", "Ошибка ввода!");
int result = GetMultiplication(numA, numB);
Console.WriteLine($"{numA} ^ {numB} -> {result}");


int GetNumberFromUserA(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber>0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int GetNumberFromUserB(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


int GetMultiplication (int numberA, int numberB)
{
    int sum = numberA;
    while (numberB > 1)
    {
        sum = sum*numberA;
        numberB--;
    }
    return sum;
}

