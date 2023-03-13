/*
Напишите программу, которая будет принимать на вход число,
а на выходе будет выдавать сумму цифр этого числа.
453 -> 12
45 -> 9
*/
using System;
using static System.Console;

int GetSum(int a)
{
    if (a == 0)
    {
        return 0;
    }

    return a % 10 + GetSum(a / 10);
}

Clear();
WriteLine("Введите число:");
int a = int.Parse(ReadLine());
WriteLine($"{a} -> {GetSum(a)}");