// Обход директория

using System;
using static System.Console;

string path = "/Users/danila/Desktop/ExamplesL/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    WriteLine(fi[i].Name);
}