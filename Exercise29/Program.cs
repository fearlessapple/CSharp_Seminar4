Console.Write("Введите кол-во элементов массива: ");
int length = int.Parse(Console.ReadLine() ?? "");

int[] array = new int[length];

FillArray(array);
PrintArray(array);

static void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите число для массива: ");
        array[index] = int.Parse(Console.ReadLine() ?? "");
        index++;
    }
}

static void PrintArray(int[] array)
{
    int length = array.Length;
    int position = 0;
    while (position < length)
    {
        Console.Write($"{array[position]} ");
        position++;
    }
}