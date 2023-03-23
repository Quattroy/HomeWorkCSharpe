// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int rows1 = GetUserNum("Введите количество строк 1 массива: ", "Ошибка ввода!");
int columns1 = GetUserNum("Введите количество столбцов 1 массива: ", "Ошибка ввода!");
int rows2 = GetUserNum("Введите количество строк 2 массива: ", "Ошибка ввода!");
int columns2 = GetUserNum("Введите количество столбцов 2 массива: ", "Ошибка ввода!");

int[,] array1 = GetArray(rows1, columns1);
Console.WriteLine();
int[,] array2 = GetArray(rows2, columns2);
Console.WriteLine();

int[,] multiplicationArray = Multiplication(array1, array2);
Console.WriteLine();
PrintArray(multiplicationArray);


/////////////////////////////////////////////////////////////////

int GetUserNum(string message, string error)
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

int[,] Multiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(0) == array2.GetLength(1))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    Console.WriteLine("Результирующая матрица:");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}