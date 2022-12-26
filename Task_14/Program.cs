using static System.Console;
Clear();
// Программа, которая на вход принимает массив из случайных чисел,
//  а на выходе показывает сумму всех двухзначных чисел!

Write("Введите длинну создаваемого списка: ");
int len = int.Parse(ReadLine()!);
int[] array = new int[len];
int sum = 0;
int index = 0;
while (index < len)
{
    array[index] = Random.Shared.Next(99);
    Write(array[index] + " ");
    
    if (array[index] > 9)
    {
        sum = sum + array[index];
    }
    index++;
}
// WriteLine(array);
WriteLine("----");
WriteLine(sum);