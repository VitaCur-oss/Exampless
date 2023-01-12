using static System.Console;
Clear();
int[] array = { 1, 5, 4, 8, 6, 3, 4, 2, 5, 8, 4, 1, 5, 9, 6 };
int m = 3;
int size = array.Length;

WriteLine(size);
int sum = 0;

for (int i = 0; i < m; i++)
{
    sum = sum + array[i];
}
WriteLine(sum);


// int j = 0;
// int temp = sum;
// while (j < size - m)
// {
//     temp = 
// }