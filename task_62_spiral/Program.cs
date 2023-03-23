// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int n = 4;
int[,] array = new int[n, n];
GetResult(array);

void GetResult(int[,] array)
{
    int i = array.GetLength(0);
    int j = array.GetLength(1);
    int[,] arr = new int[i, j];
    if(i == 0)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                arr[k, l] = new Random().Next(-100, 100);
                Console.Write($"{arr[i, j]}  ");
            }
        }
    }
    if(i > 0 && j == 3)
    {
       for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                arr[k, l] = new Random().Next(-100, 100);
                Console.Write($"{arr[i, j]}  ");
            }
        }
    }
    if(i == 3 && j < 3)
    {
       for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                arr[k, l] = new Random().Next(-100, 100);
                Console.Write($"{arr[i, j]}  ");
            }
        }
    }
    if(i > 0 && i < 3 && j == 0)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                arr[k, l] = new Random().Next(-100, 100);
                Console.Write($"{arr[i, j]}  ");
            }
        }
    }
    if(i == 1 && j > 0 && j < 3)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                arr[k, l] = new Random().Next(-100, 100);
                Console.Write($"{arr[i, j]}  ");
            }
        }
    }
    if(i == 2 && j == 2)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                arr[k, l] = new Random().Next(-100, 100);
                Console.Write($"{arr[i, j]}  ");
            }
        }
    }
    if(i == 2 && j == 1)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                arr[k, l] = new Random().Next(-100, 100);
                Console.Write($"{arr[i, j]}  ");
            }
        }
    }
}