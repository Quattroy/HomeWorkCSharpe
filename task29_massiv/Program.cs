//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.


Console.Clear();
int length = Write("Длина массива: ");
int min = Write("Начальное значение для диапазона случайных чисел: ");
int max = Write("Конечное значение для диапазона случайных чисел: ");
int[] array = GetArray(length, min, max);

PrintArray(array);


//////////////////////////////////////////////////////////////////////////////////

int Write(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] GetArray(int length, int min, int max)
{
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, "); //вывод значения массива
    }
    Console.Write($"{array[array.Length -1]}"); // вывод значения массива
    Console.Write("]");
}