﻿// В случайных точках консоли вывести случайные числа

using System;

Console.Clear();

Random r = new Random();

Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
    );
    Console.Write(r.Next(10));
    Thread.Sleep(10);
}