Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");

SumCalculate(number);

static void SumCalculate(int number)
{
    int number1 = number;
    int sum = 0;
    while (number > 0)
    {
        int LastDigit = number % 10;
        int LastNumber = number / 10;
        number = LastNumber;
        sum = sum + LastDigit;
    }
    Console.Write($"{number1} -> {sum}");
}