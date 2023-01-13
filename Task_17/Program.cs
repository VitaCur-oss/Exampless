using static System.Console;
Clear();

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Write("Выедите число: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);
WriteLine($"Sum number 1...A = {sum}");


int GetSum(int A)
{
    int result = 0;
    while (A > 0)
    {
        result += A;
        A--;
    }
    return result;
}

