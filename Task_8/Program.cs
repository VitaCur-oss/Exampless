using static System.Console;
Clear();

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// // WriteLine(array[4]);
// array[1] = 45;
// WriteLine(array[1]);

// int[] array = { 1, 98, 38, 5, 52, 7, 98, 54, 45 };
// // WriteLine(array.Length);
// int n = array.Length;
// int find = 98;
// int index = 0;
// while(index < n)
// {
//     if (array[index] == find)
//     {
//         WriteLine(index);
//         break;
//     }
//     index++;
// }
int[] array = new int[10];


// WriteLine(array);
void FillArray(int[] Collection)
{
    int lenght = Collection.Length;
    int index = 0;
    while (index < lenght)
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] Col)


{
    int count = Col.Length;
    int position = 0;
    while (position < count)
    {
        WriteLine(Col[position]);
        position++;
    }
}

FillArray(array);
array[2] = 4;
array[3] = 4;
PrintArray(array);

int IndexOff(int[] collection, int find)
{
    int index = 0;
    int position = -1;
    int lenght = collection.Length;
    while (index < lenght)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int pos = IndexOff(array, 44);
WriteLine(pos);
