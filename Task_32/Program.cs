// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();

Write("Введите число N: ");
int N = int.Parse(ReadLine()!);
int[] fibb = Fibboo(N);
// WriteLine(Fibboo(N));
WriteLine($"Если N = {N} -> {String.Join(" ", fibb)}");

int[] Fibboo(int num)
{
    int[] result = new int[num];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < num; i++)
    {
        
        result[i] = result[i - 1] + result[i - 2];
        // Write(result[i]);
    }
    return result;
}
