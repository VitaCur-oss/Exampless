using static System.Console;
Clear();

// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
//  [-4, -8, 8, 2] -> [4, 8, -8, -2]

Write("Введите  размер массива, мин и мах значения диапазона: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();
int[] array1 = ChangeArray(array);
PrintArray(array1);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue);
    }
    return resultArray;
}

void PrintArray(int[] prarray)
{
    Write("[");
    for (int i = 0; i < prarray.Length - 1; i++)
    {
        Write($"{prarray[i]}, ");
    }
    Write($"{prarray[prarray.Length - 1]}]");
}

int[] ChangeArray(int[] charray)
{
    int[] chr = new int[charray.Length];
    for (int i = 0; i < charray.Length; i++)
    {
        chr[i] = charray[i] * -1;
    }
    return chr;
}
