using static System.Console;
Clear();
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);

WriteLine(a * a == b || b * b == a ? "Yes" : "No");