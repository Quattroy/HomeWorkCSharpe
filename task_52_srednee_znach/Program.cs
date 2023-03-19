// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int rows = GetUserNum1("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetUserNum2("Введите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns);
GetResult(array, rows, columns);

int GetUserNum1(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}

int GetUserNum2(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}

int[,] GetArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    return arr;

}

void GetResult(int[,] array, int rows, int columns)
{
    for (int i = 0; i < columns; i++) // для столбца перебираем значения по строкам
    {
        double sum = 0;
        int count = 0;
        for (int j = 0; j < rows; j++) // значения строки
        {
            sum += array[j, i];
            count++;
        }
        double result = sum / count;
        Console.WriteLine($"Среднее арифмитическое столбца №{i} = {Math.Round(result,1)}");

    }
}