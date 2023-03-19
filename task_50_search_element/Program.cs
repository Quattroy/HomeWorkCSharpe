// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
int rows = GetUserNum1("Введите номер строки: ", "Ошибка ввода!");
int columns = GetUserNum2("Введите номер столбца: ", "Ошибка ввода!");
int[,] array = GetArray(20, 10);
GetResult(array, rows, columns);


int GetUserNum1(string message, string error)
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

int GetUserNum2(string message, string error)
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
    if(rows-1 <= 20 && columns-1 <=10)
    Console.WriteLine($"Позиция элемента с номером строки {rows} и номером столбца {columns} равна {array[rows-1,columns-1]}");
    else
    Console.WriteLine($"Позиция элемента с номером строки {rows} и номером столбца {columns} НЕ СУЩЕСТВУЕТ!");
}
    