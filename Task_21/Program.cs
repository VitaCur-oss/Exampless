using static System.Console;
Clear();

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Write("Введите длинну массива: ");
int arr = int.Parse(ReadLine()!);
int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
// GetBinarryArr(arr);
PrintArray(GetBinarryArr(arr));
WriteLine();
PrintArray(ChangeArray(arr1));



int[] GetBinarryArr(int ar)
{
    int[] res = new int[ar];
    for (int j = 0; j < ar; j++)
    {
        res[j] = new Random().Next(0, 2);
        // Write(res[j]);
    }
    return res;
}

void PrintArray(int[] arrr)
{
    for (int j = 0; j < arrr.Length; j++)
    {
        Write(arrr[j]);
    }
}

int[] ChangeArray(int[] ar1)
{
    int[] resu = new int[ar1.Length];
    for (int i = 0; i < ar1.Length; i++)
    {
        resu[i] = new Random().Next(0, 2);
    }
    return resu;
}