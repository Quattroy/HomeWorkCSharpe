// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1 = InputNum("Ведите знчение ", "Ощибка ввода!");
int k1 = InputNum("Ведите знчение ", "Ощибка ввода!");
int b2 = InputNum("Ведите знчение ", "Ощибка ввода!");
int k2 = InputNum("Ведите знчение ", "Ощибка ввода!");
int x = ResultX(b1, k1, b2, k2);
TochkaPeresecheniaY(b1, b2, k1, k2, x);


int InputNum(string message, string error)
{
    while (true)
    {
        Console.Write(message);
        bool num = int.TryParse(Console.ReadLine(), out int numUser);
        if (num) return numUser;
        else Console.WriteLine(error);
    }
}
int ResultX(int b1, int k1, int b2, int k2)
{
    int x = (b2 - b1) / (k1 - k2);
    return x;
}
void TochkaPeresecheniaY(int b1, int b2, int k1, int k2, int x)
{
    int Y1 = k1 * x + b1;
    int Y2 = k2 * x + b2;
    if (Y1 == Y2)
    {
        Console.WriteLine($"Прямые имеют одну точку пересечения с координатами {x} и {Y1}");
    }
    else { Console.WriteLine("Прямые параллельные"); }
}