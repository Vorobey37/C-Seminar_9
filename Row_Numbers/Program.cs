/*
Задайте M и N, напишите ряд чисел от M до N
*/
using System;
using static System.Console;

WriteLine("Введите m:");
int m = int.Parse(ReadLine());
WriteLine("Введите n:");
int n = int.Parse(ReadLine());
string row = PrintRowNumbers (m, n);
string PrintRowNumbers (int m, int n)
{
    if (n == m)
    {
        Write($"{m}");
    }
    else Write($"{PrintRowNumbers (m, n-1)} {n}");
    return string.Empty;
}