﻿// Сортировка массива

using System;
using static System.Console;

Clear();

int[] arr = { 1, 3, 4, 6, 5, 7, 2, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);