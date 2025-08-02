// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;


Console.Write("Enter string: ");
string str = Console.ReadLine();

string pattern = "virus";
int count = 0;

for (int i = 0; i <= str.Length - pattern.Length; i++)
{
    if (str.Substring(i, pattern.Length) == pattern)
        ++count;        
}

Console.WriteLine(count);
