using static System.Console;
Clear();

// **Задача 63:** Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string numb = GetNumber(5);
// WriteLine(numb);
// GetNumber1(10);

string GetNumber(int num)
{
    return (num == 1) ? num.ToString() : $"{GetNumber(num - 1)}, {num}";
    // if (num == 1) return num.ToString();
    // else return $"{GetNumber(num - 1)}, {num}";
}

void GetNumber1(int num)
{
    if (num == 1) Write(num);
    else
    {
        GetNumber1(num - 1);
        Write($", {num}");
    }
}

WriteLine(NumbersSumRec(15, 1));
// int sumRecUP(int m, int n) 
// { 
//     if(m== n+1) return 0; 
//     else return m + sumRecUP(m+1, n); 
// } 

int NumbersSumRec(int m, int n)
{
    if (m > n)
    {
        if (m == n - 1) return 0;
        return m + NumbersSumRec(m - 1, n);
        // return sumRec(m, n); 
    }

    if (m < n)
    {
        if (m == n + 1) return 0;
        else return m + NumbersSumRec(m + 1, n);
        // return sumRecUP(m, n); 
    }

    else return m;
}
