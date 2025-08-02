// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;


Console.Write("Enter string: ");
string str = Console.ReadLine();

if (string.IsNullOrEmpty(str))
{
    Console.WriteLine("Empty string");
    return;
}


bool isNewWord = true;
StringBuilder stringBuilder = new StringBuilder();

foreach(char c in str)
{
    if (c == ' ')
        isNewWord = true;
    else
    {
        if (isNewWord)
        {
            stringBuilder.Append(Char.ToUpper(c));
            isNewWord = false;
        }
        else
        {
            stringBuilder.Append(c);
        } 
    }
}

Console.WriteLine("Ret:" + stringBuilder.ToString());
