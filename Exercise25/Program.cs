Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine() ?? "");

int sum = 1;

for (int i = 1; i <= numberB; i++)
{
    sum =  numberA * sum;
}
Console.WriteLine($"{numberA}, {numberB} -> {sum}");