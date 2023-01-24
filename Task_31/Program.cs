using static System.Console;
Clear();

// Счастливые билетики

Write("Введите номер билетика(шесть цифр): ");
string[] ticket = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
bool happy = IsHappy(ticket);
WriteLine(happy);

bool IsHappy(string[] arr)
{
    int first = 0;
    int second = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        first += int.Parse(arr[i]);
        
        second += int.Parse(arr[arr.Length -1 - i]);
    }
    WriteLine(first);
    WriteLine(second);
    return (first == second);
}
