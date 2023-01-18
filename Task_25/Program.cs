using static System.Console;
Clear();

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] Arr = GetArray(123, 1, 110);
PrintArray(Arr);
WriteLine();
int counter = Count(Arr);
WriteLine(counter);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int Count(int[] arr)
{
    int cou = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i]<= 99) cou++;
    }
    return cou;
}

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        Write($"{array[i]}, ");
    }
    Write($"{array[array.Length -1]}]");
}
