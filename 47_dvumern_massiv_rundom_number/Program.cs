// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int rows = GetUserNumber1("Введите количество строк массива: ", "Ошибка! Введено некоректное значение");
int columns = GetUserNumber2("Введите количество столбцов массива: ", "Ошибка! Введено некоректное значение");
double[ , ] array = GetArray(rows, columns);
PrintArray(array);

int GetUserNumber1(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0)
            return num;
        Console.WriteLine(error);
    }
}

int GetUserNumber2(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0)
            return num;
        Console.WriteLine(error);
    }
}

double[,] GetArray(int rows, int columns)
{
    double[,] arr = new double[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble()*100,2);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();

    }
}