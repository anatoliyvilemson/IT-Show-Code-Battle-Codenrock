/* Задание:
RLE - самый простой алгоритм сжатия. Его суть состоит в замене повторяющихся данных образцом, и количеством повтора образца. 
Алгоритм подходит для сжатия данных, имеющих большое количество повторений.  
При сжатии учитывайте регистр. 
Напишите программу, которая реализует RLE для строк, состоящих из букв латинского алфавита, не имеющих пробелы. 
Во входных данных только одна строка. 
Например: DDDDFFFFHHHHk → 4D,4F,4H,1k
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
public class Rle
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        string response = "something: ";
        string line;
        while ((line = Console.ReadLine()) != null && line != "")
        {
            response += line;
        }

        var solution = new Rle();
        solution.Compression(response);
    }
    public string Compression(string response)

    {
        var input = string.Join("", response.Skip(response.IndexOf(' ', 0)).Where(ch => Char.IsLetter(ch)));
        var regex = new Regex(@"(\w)\1*", RegexOptions.Multiline);

        response = regex.Replace(input, match => $"{match.Length}{match.Value[0]},").TrimEnd(',');

        Console.WriteLine(response);
        return response;
    }
}
