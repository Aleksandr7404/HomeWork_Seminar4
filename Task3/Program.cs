//  Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 100);// Array3digits[i] = new Random().Next(100,1000);
    }
    return array;
}

void revol_array(int[] arr)
{
    int buff = 0;
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
    {
        buff = arr[i];
        arr[i] = arr[size - 1 - i];
        arr[size - 1 - i] = buff;
    }
}

void ShowArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write($"{Arr[i]} ");
    }
}

int[] arr1 = CreateArray(10);
ShowArray(arr1);
revol_array(arr1);
Console.WriteLine();
ShowArray(arr1);