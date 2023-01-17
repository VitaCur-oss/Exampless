using static System.Console;
Clear();

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = { 1, 5, 8, 6, 1, -4, -9, -2 };
bool find = Find(array, 6);
PrintArray(array);
WriteLine($" -> {find}");

bool Find(int[] farray, int num)
{
    for (int i = 0; i < farray.Length; i++)
    {
        if (farray[i] == num) return true;
    }
    return false;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length - 1]}]");
}
