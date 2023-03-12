//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int length = WriteLength("Введите длину массива ", "Ошибка! Введено некорректное значение ");
int min = Write("Введите минимальное положительное 3х значное значение ", "Ошибка! Введено некорректное значение ");
int max = Write("Введите максимальное положительное 3х значное значение ", "Ошибка! Введено некорректное значение ");

int[] array = GetArray(length, min, max);
Console.WriteLine(String.Join(" ", array));
int result = GetResult(array);
PrintResult(result);

int WriteLength(string message, string error)
{
    int num = 0;
    while (true) 
    {
        try 
        {
            Console.Write(message);
            num = int.Parse(Console.ReadLine() ?? "");
            if(num>0) break;
            else Console.WriteLine(error);
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{error} {exc.Message}"); 
         }
    }
    return num;
}
int Write(string message, string error)
{
    int num = 0;
    while (true)
    {
        try
        {
            Console.WriteLine(message);
            num = int.Parse(Console.ReadLine() ?? "");
            if(num > 99 && num <1000 ) break;
            else Console.WriteLine(error);
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{error} {exc.Message}");
        }
    }
    return num;
}
int[] GetArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
int GetResult(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) 
        count++;
        
    }
    return count;
}
void PrintResult(int result)
{
    Console.WriteLine($"Количестов четных чисел в масиве равно {result}");
}