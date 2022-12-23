// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).
using static System.Console;
Clear();

WriteLine("Введите номер четверти: ");
int a = int.Parse(ReadLine()!);

// WriteLine(a <1 || a > 4? "Ошибка": a == 1 ? "x>0 y>0" : a == 2 ? "x<0 y>0": a == 3 ? "x < 0 y < 0" : "x > 0 y <0");
switch(a)
{
    case 1:
    {
        WriteLine("x>0 y>0");
        break;
    }
    case 2:
    {
        WriteLine("x<0 y>0");
        break;
    }
    case 3:
    {
        WriteLine("x < 0 y < 0");
        break;
    }
    case 4:
    {
        WriteLine("x > 0 y <0");
        break;
    }
    default:
    {
        WriteLine("Ошибка");
        break;
    }
}
