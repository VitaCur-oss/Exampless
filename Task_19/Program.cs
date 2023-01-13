using static System.Console;
Clear();

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int multi = GetMulti(number);
WriteLine(multi);

int GetMulti(int A)
{
    if (A > 0)
    {
        int result = 1;
        while (A > 0)
        {
            result *= A;
            A--;

        }
        return result;
    }
    else
    {
        int result = 0;
        return result;
    }
    
}