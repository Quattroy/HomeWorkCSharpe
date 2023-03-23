// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int rows = GetUserNum("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetUserNum("Введите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns);
Console.WriteLine();
int[] arrMin = SearchMin(array);
Console.WriteLine();
ResultMinRows(arrMin);


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

int[] SearchMin(int[,] array)
{
    int[] rezult = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        rezult[i] = sum;
        Console.WriteLine($"Сумма {i} строки = {sum}  ");
    }
    return rezult;
}

void ResultMinRows(int[] arrMin)
{
        int minPosition = 0;
        for (int k = 1; k < arrMin.Length-1; k++)
        {
            if (arrMin[k] < arrMin[minPosition]) 
            minPosition = k;
        }
        Console.Write($"номер строки с наименьшей суммой элементов: {minPosition} строка");
    
    
}
