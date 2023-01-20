// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.



using static System.Console;
Clear();

Write("Введите стороны треугольника через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine();
bool triangle = IsTriangle(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
WriteLine(triangle);

bool IsTriangle(int A, int B, int C)
{
    if (A + B > C && A + C > B && B + C > A) return true;
    return false;
}
