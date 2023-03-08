//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
int numA = GetNumberFromUserA("Введите целое число А: ", "Ошибка ввода!");
int result = GetSum(numA);
Console.WriteLine($"Сумма цифр числа {numA}  равна {result}");


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


int GetSum(int numberA)
{
    int sum = 0;
    while (numberA > 0)
    {
        int num = numberA%10;
        sum = sum + num;
        numberA = numberA/10;
    }
    return sum;
}



