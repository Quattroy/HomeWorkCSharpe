Console.Write("Введите число №1: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число №2: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число №3: ");
double thirdNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
    Console.Write("max = " + firstNumber);
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
    Console.Write("max = " + secondNumber);
else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
    Console.Write("max = " + thirdNumber);
else Console.Write("числа равны");