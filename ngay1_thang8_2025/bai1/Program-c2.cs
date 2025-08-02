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

StringBuilder stringBuilder = new StringBuilder();
int count = 1;

for (int i = 0; i != str.Length; i++)
{
    while ((i + 1 < str.Length) && str[i] == str[i + 1])
    {
        ++count;
        ++i;
    }

    stringBuilder.Append(str[i]);
    stringBuilder.Append(count);

    count = 1;
}

Console.WriteLine("Ret: " + stringBuilder.ToString());
