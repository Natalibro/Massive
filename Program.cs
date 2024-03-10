// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
using System.Net.Security;
using System.Xml.XPath;

string input_string = "Hello my world";
string result = "";
string[] temp_array = input_string.Split(" ");
for(int i = temp_array.Length-1;i >= 0; i--)
{
    result += temp_array[i];
    result += " ";
} 
Console.Write(result);
