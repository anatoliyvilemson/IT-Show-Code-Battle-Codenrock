/* Зашифруйте сообщение меняя буквы на их порядковый номер в алфавите. Пробелы при этом не учитывать. Строки будут даны без знаков препинания, только с пробелами. Регистр не учитывать. 
Входные данные: шифруемая строка, длиной до 1000 символов, на латинице.
Пример входных данных: 
MR Robot
Выходные данные: через запятую порядковый номер букв в алфавите
Пример выходных данных: 
13,18,18,15,2,15,20 */
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
public class Alphabet
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

        var solution = new Alphabet();
        solution.Encryption(response);
    }
    public string Encryption(string response)

    {
        var input = response.ToUpper().Skip(response.IndexOf(' ', 0)).Where(ch => Char.IsLetter(ch));
        response = string.Join(",", input.Select(ch => ch - 'A' + 1)); 

        Console.WriteLine(response);
        return response;
    }
}
