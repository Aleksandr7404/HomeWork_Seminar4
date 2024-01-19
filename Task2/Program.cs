// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array3digits = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array3digits[i] = rnd.Next(100, 1000);// Array3digits[i] = new Random().Next(100,1000);
    }
    return array3digits;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ShowAmountEven(int[] arr3d)
{
    int amount = 0;
    for (int i = 0; i < arr3d.Length; i++)
    {
        if (arr3d[i] % 2 == 0)
        {
            amount++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел: {amount}");
}
Console.Clear();
int[] array = CreateArray(10);
ShowArray(array);
ShowAmountEven(array);