﻿using static System.Console;
Clear();

// **Задача 39:** Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);

int[] array = GetArray(arraySize);
WriteLine($"[{String.Join(" ", array)}]");
ReverseArray1(array);
WriteLine($"[{String.Join(" ", array)}]");

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1, 10);
    }
    return resultArray;
}

void ReverseArray1(int[] inarr)
{
    for (int i = 0; i < inarr.Length / 2; i++)
    {
        int temp = inarr[i];
        inarr[i] = inarr[inarr.Length - 1 - i];
        inarr[inarr.Length - 1 - i] = temp;
    }
}
    



















// Write("Ведите размер массива: ");
// int arraySize = int.Parse(ReadLine()!);
// int[] array = GetArray(arraySize);

// WriteLine($"[{String.Join(",", array)}]");
// ReverseArray2(array);
// WriteLine($"[{String.Join(",", array)}]");
// //WriteLine($"[{String.Join(",", ReverseArray1(array))}]");

// int[] GetArray(int size)
// {
// int[] resultArray = new int[size];
// for (int i = 0; i < size; i++)
// {
// resultArray[i] = new Random().Next(1, 10);
// }
// return resultArray;
// }

// int[] ReverseArray1(int[] inArray)
// {
// int[] result = new int[inArray.Length];
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];
// }
// return result;
// }

// void ReverseArray2(int[] inArray)
// {
// for (int i = 0; i < inArray.Length/2; i++)
// {
// int temp = inArray[i];
// inArray[i] = inArray[inArray.Length - 1 - i];
// inArray[inArray.Length - 1 - i] = temp;
// }

