//Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр
// которого чётная.
Console.Clear();
bool CheckEvenSum(int number)
{
    bool even = false;
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    if (sum % 2 == 0)
    {
        even = true;
    }
    return even;
}

while (true)
{
    Console.Write("Введите натуральное число или q для выхода : ");
    string n = Console.ReadLine();
    if (n == "q")
    {
        Console.Write("Выход");
        break;
    }
    if (int.TryParse(n, out int num))
    {
        if (CheckEvenSum(num) == true)
        {
            Console.Write("Сумма цифр четная");
            break;
        }
        else
            Console.WriteLine("Сумма цифр нечетная");
    }
    else
        Console.WriteLine("Некорректный ввод");
}