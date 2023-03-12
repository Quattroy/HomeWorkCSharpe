//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();
int length = WriteLength("Введите длину массива ", "Ошибка! Введено некорректное значение ");
double[] array = GetArray(length);
Console.WriteLine(String.Join(" ", array));
double min = GetMin(array);
double max = GetMax(array);
double result = GetResult(max, min);
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

double[] GetArray(int length)
{
    double[] arr = new double[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().NextDouble()*1000;
    }
    return arr;
}
double GetMin(double[]arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}
double GetMax(double[]arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}
double GetResult(double max, double min)
{
    double result = max - min;
    return result;
}

void PrintResult(double result)
{
    Console.WriteLine($"Разница между максимальным элементом массива {max} и минимальным элементом массива {min} равна {result}");
}