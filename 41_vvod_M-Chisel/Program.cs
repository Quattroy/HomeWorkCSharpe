//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
int CountInput = GetCountInput("Введите количество чисел: ", "Ошибка ввода!");
int[] array = GetUserNumber(CountInput);
int CountPositive = ResultCountPositive(array);
Console.WriteLine($"Среди введенных пользователем чисел {String.Join(", ", array)}, чисел больше нуля {CountPositive}");



//Узнаем количество чисел для ввода
int GetCountInput(string message, string error)
{
    while (true)
    {
        Console.Write(message);
        bool num = int.TryParse(Console.ReadLine(), out int count);
        if (num && count > 0)
            return count;
        Console.Write(error);
    }
}
// На основании запросов на ввод чисел заполняем массив
int[] GetUserNumber(int countInput)
{

    int[] arr = new int[countInput];
    for (int i = 0; i < CountInput; i++)
    {
        while (true)
        {
            Console.WriteLine($"Введите {i} значение из {CountInput}: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if (isCorrect)
            {
                arr[i] = userNumber;
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение!");
            }
        }
    }
    return arr;


}
//Считаем количество чисел больше 0
int ResultCountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}