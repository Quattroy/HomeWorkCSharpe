Console.Write("Введите число : ");
int Number = int.Parse(Console.ReadLine() ?? ""); 
if(Number%2 == 0)
    Console.Write("число четное");
else Console.Write("число нечетное");

