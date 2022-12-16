// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

//3 -> Среда
//5 -> Пятница

using static System.Console;
Clear();

Write("Введите число дня недели: ");
int a = int.Parse(ReadLine());

if (a >= 1 & a <=7) 
{
    if (a == 1) {WriteLine("Понедельник");}
    else if (a == 2) {WriteLine("Вторник");}
    else if (a == 3) {WriteLine("Среда");}
    else if (a == 4) {WriteLine("Четверг");}
    else if (a == 5) {WriteLine("Пятница");}
    else if (a == 6) {WriteLine("Суббота");}
    else if (a == 7) {WriteLine("Воскресенье");}
}
else {WriteLine("В неделе всего 7 дней!");}