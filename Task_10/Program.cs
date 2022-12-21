// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да
// */
using static System.Console;
Clear();
int a = int.Parse(ReadLine()!);
WriteLine(a);
WriteLine((a % 7 == 0) && (a % 23 == 0) ? "Yes": "No");