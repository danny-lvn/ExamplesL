/*
Дан текст. В тексте нужно:
все пробелы заменить черточками,
маленькие буквы "к" заменить на большие буквы "К",
а большие буквы "С" заменить на маленькие буквы "с".
*/

using System;
using static System.Console;

Clear();

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string text1 = Replace(text, ' ', '|');
Console.WriteLine(text1);
Console.WriteLine();

string text2 = Replace(text1, 'к', 'К');
Console.WriteLine(text2);
Console.WriteLine();

string text3 = Replace(text2, 'С', 'с');
Console.WriteLine(text3);
Console.WriteLine();