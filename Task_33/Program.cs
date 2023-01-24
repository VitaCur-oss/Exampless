using static System.Console;
Clear();

//  Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Write("Введите размер строки, столбца, диапазон: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
PrintMatrixArray(array);

int[,] GetMatrixArray(int cows, int colums, int minvalue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[cows, colums];
    for (int i = 0; i < cows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = rnd.Next(minvalue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Write($"{inarray[i, j],4} ");
        }
        WriteLine();
    }
}
