using static System.Console;
Clear();

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int num = GetNum(number);
WriteLine(num);

int GetNum(int A)
{
    int count = 0;
    while (A > 0)
    {
        A = A / 10;
        count++;
    }
    return count;
}
        