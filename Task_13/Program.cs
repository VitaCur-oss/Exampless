using static System.Console;
Clear();
WriteLine("Введите число дня недели: ");
int a = int.Parse(ReadLine()!);

switch(a)
{
    case 1:
    {
        WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        WriteLine("Вторник");
        break;
    }
    case 3:
    {
        WriteLine("Среда");
        break;
    }
    case 4:
    {
        WriteLine("Четверг");
        break;
    }
    case 5:
    {
        WriteLine("Пятница");
        break;
    }
    case 6:
    {
        WriteLine("Суббота");
        break;
    }
    case 7:
    {
        WriteLine("Воскресенье");
        break;
    }
    default:
    {
        WriteLine("Ошибка!");
        break;
    }
}