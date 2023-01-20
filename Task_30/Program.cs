using static System.Console;
Clear();

// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Write("Введите число, которое переведем из десятичной системы в двоичную: ");
int num = int.Parse(ReadLine()!);
WriteLine($"{num} -> {DecInBin(num)}");


string DecInBin(int number)
{
    if (number == 0) return "0";
    string result = String.Empty;
    int rum;
    while(number > 0)
    {
        rum = number % 2;
        number /= 2;
        result = rum.ToString() + result;
    }
    return result;
}
