using static System.Console;
Clear();

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//   Результат запишите в новом массиве.

Write("Введите размер массива, мин мах диапазона через пробел: ");
string[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[] arr = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(arr);
WriteLine();
int[] multi = MultiArr(arr);
PrintArray(multi);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
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

int[] MultiArr(int[] array1)
{
    int size = 0;
    if (array1.Length % 2 == 0)size = array1.Length / 2;
    else size = array1.Length / 2 + 1;
    int[] Res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Res[i] = array1[i] * array1[array1.Length - 1 - i];
    }
    return Res;
}
        
    
    
        
     
    
