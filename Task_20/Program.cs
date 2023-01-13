using static System.Console;
Clear();

// Программа, которая суммирует числа от 1 до N, если число делимое от N делиться без остатка.

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int sumi = GetSumI(number);
WriteLine(sumi);


int GetSumI(int A)
{
    int c = A;
    int result = 0;
    while (c > 0)
    {
        if (A % c == 0)
        {
            result += c;
        }
        c--;
    }
    return result;
}