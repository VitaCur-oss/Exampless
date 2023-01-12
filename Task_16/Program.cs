using static System.Console;
Clear();
void Multi()
{
    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            WriteLine($"{i} x {j} = {i * j}");
        }
        WriteLine();
    }
}
// Multi();

int Method()
{
    return DateTime.Now.Year;
}
int year = Method();
// WriteLine(year);

void Method2(int count, string msg)
{
    for (int i = 0; i < count; i++)
    {
        WriteLine(msg);
    }
}
// Method2(5, "Hello");
// Method2(msg: "Hi", count: 3);

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string text = " — Я думаю, — сказал князь, улыбаясь, — что,ежели бы вас послали вместо нашего милого Винценгеродевы бы взяли приступом согласие прусского короля.так красноречивы. Вы дадите мне чаю? ";

string replace = Replace(text, ' ', '*');
// WriteLine(replace);
// WriteLine();
string replace1 = Replace(replace, 'с', 'C');
// WriteLine(replace1);
// WriteLine();
string replace2 = Replace(replace1, 'к', 'К');
// WriteLine(replace2);

int[] array = { 1, 5, 6, 8, 4, 3, 1, 9, 4, 6 };
void PrintArr(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)

    {
        Write(array[i]);
        Write(' ');
    }
}

// int arr = PrintArr(array);
// WriteLine(arr);
void SelectionArr(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            int minposition = i;
            if (array[j] > array[minposition])
            {
                minposition = j;

            }
            int temporary = array[i];
            array[i] = array[minposition];
            array[minposition] = temporary;
        }

    }
}
PrintArr(array);
WriteLine();
SelectionArr(array);
PrintArr(array);