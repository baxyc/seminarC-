﻿// Напишите программу, которая принимает на вход трех значное число и на выходе показывает последнию цифру этого числа

int TakeNum(int num)
{
    return num % 10;

}

Console.WriteLine(TakeNum(678));