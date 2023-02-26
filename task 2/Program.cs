Console.Write("Введите число №1: ");
double firstNumber = Convert.ToDouble(Console.ReadLine ());
Console.Write("Введите число №2: ");
double secondNumber = Convert.ToDouble(Console.ReadLine ());
if(firstNumber > secondNumber)
    Console.Write("max = "+ firstNumber);
else if(secondNumber > firstNumber)
    Console.Write("max = "+ secondNumber);
else Console.Write("числа равны");
