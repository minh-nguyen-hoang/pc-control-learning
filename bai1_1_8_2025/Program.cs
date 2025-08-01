// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.ComponentModel.Design;


/*
 *  Bài 1. Đề bài: Đầu vào là các kí tự chữ cái (a->z, A->Z), Đầu ra mong muốn như ví dụ sau:
    Ví dụ: 
    Input: aaabbc
    Output: a3b2c1
    Input: ggggbkkc
    Output:g4b1k2c
 */

Console.Write("Enter string: ");
string str = Console.ReadLine();

int right_pos = 0, left_pos = 0;
string ret = "";

while (right_pos != str.Length)
{
    if (str[right_pos] != str[left_pos])
    {
        ret += str[left_pos] + Convert.ToString(right_pos - left_pos);

        left_pos = right_pos;
    }

    ++right_pos;
}

ret += str[left_pos] + Convert.ToString(right_pos - left_pos);


Console.Write("Result: " + ret);
