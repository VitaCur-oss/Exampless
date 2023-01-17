using static System.Console;
Clear();

Write("Введите размер массива, его мин и мах диапазон, через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(parameters.Length);

int[] array1 = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array1);
WriteLine();
int negativeSum = 0;
int positiveSum = 0;

foreach (var a in array1)
{
    negativeSum += (a < 0) ? a : 0;
    positiveSum += (a > 0) ? a : 0;
}

WriteLine($"{negativeSum}    {positiveSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr1 = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        arr1[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr1;
}

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }
    Write($"{array[array.Length - 1]}]");
}