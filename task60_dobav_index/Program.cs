// Задача 60.Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно
//  выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();
int x = GetUserNum("Введите значение массива X: ", "Ошибка ввода!");
int y = GetUserNum("Введите значение массива Y: ", "Ошибка ввода!");
int z = GetUserNum("Введите значение массива Z: ", "Ошибка ввода!");

int[,,] array = GetArray(x, y, z);

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

int[,,] GetArray(int x, int y, int z)
{
    int[,,] arr = new int[x, y, z];
    int minNum = 10; // минимальное значение для для присовения двузначных, неповторяющихся значений
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                if (minNum < 100) // проверка на возможность присвоения неповторяющегося двузначного значения
                {
                    arr[i, j, k] = minNum;
                    Console.Write($"{arr[i, j, k]} ({i},{j},{k})\t");
                }
                else // если невозможно невозможно дальнейшее заполнение массива 
                     //неповторяющимися двузначными значениями - выдаст ошибку. Заполнение массива прекратится.
                {
                    Console.WriteLine(); // для красоты вывода ошибки
                    Console.WriteLine("Ошибка! Дальнейшее заполнение массива неповторяющимися двухзначными числами НЕ ВОЗМОЖНО! Задайте другой размер массива!");
                    return arr;
                }
                minNum = minNum + 1;
            }
        }
        Console.WriteLine();
    }
    return arr;
}











