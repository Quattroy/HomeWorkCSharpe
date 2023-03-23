// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int rows = GetUserNum("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetUserNum("Введите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns);
SortArray(array);
Console.WriteLine("Отсортированный массив:");
PrintArraySort(array);

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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int maxPosition = j; // флажок для фиксации максимальной позиции
            for (int k = j + 1; k < array.GetLength(1); k++)// k - переменная для перебора позиций столбцов по строке
            {
                if (array[i, k] > array[i, maxPosition])
                    maxPosition = k;
            }
            int temporary = array[i, j]; // временная переменная для замены значения в массиве
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }

    }
}
void PrintArraySort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}