//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Clear();
int length = WriteLength("Введите длину массива ", "Ошибка! Введено некорректное значение ");
int min = Write("Введите минимальное значение ", "Ошибка! Введено некорректное значение ");
int max = Write("Введите максимальное значение ", "Ошибка! Введено некорректное значение ");

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
            break;
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
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i%2 != 0) 
        sum +=arr[i];
        
    }
    return sum;
}
void PrintResult(int result)
{
    Console.WriteLine($"Сумма элементов на нечетных позициях в масиве равна {result}");
}