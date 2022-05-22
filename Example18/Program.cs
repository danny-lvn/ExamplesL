using System;
using static System.Console;

Clear();

double Factorial (int n)
{
    if (n == 0) return 1;
    else if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    WriteLine($"{i}! = {Factorial(i)}");
}