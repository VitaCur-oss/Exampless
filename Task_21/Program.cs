using static System.Console;
Clear();

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Write("Введите длинну массива: ");
int arr = int.Parse(ReadLine()!);

GetBinarryArr(arr);
PrintArray(GetBinarryArr(arr));


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
    for (int j = 0; j < arr; j++)
    {
        Write(arrr[j]);
    }
} 
