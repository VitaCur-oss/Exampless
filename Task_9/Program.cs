using static System.Console;
Clear();

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

int a = new Random().Next(100, 1000);
WriteLine(a);
Write(a / 100);
WriteLine(a % 10);
