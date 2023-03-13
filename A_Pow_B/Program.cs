/*
Напишите программу, которая будет принимать на вход число A и В,
а на выходе будет выдавать A в в степени В.
А=3; В=5 -> 243

*/

using System;
using static System.Console;

int GetPow(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    return a*GetPow(a, b-1);
}

Clear();
WriteLine("Введите число А:");
int a = int.Parse(ReadLine());
WriteLine("Введите число В:");
int b = int.Parse(ReadLine());
WriteLine($"A={a}; B={b} -> {GetPow(a, b)}");
