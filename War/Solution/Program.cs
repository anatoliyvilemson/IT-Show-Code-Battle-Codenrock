/* Задание:
На рисунке изображен клин треугольником, ряды противника прямоугольником. 
Чтобы образовать клин надо, знать число человек в ряду противника, в задней части клина количество участников равно количеству человек в ряду у противника. 
В каждом ряду клина на два участника меньше, чем в предыдущем ряду. 
На острой части клина может быть либо 2 либо 1 участник. 
Так если в ряду у противника 9 человек то ряды клина состоят из такого количества человек: 
9
7
5
3
1
Или для 6 человек в ряду у противника: 
6
4
2
По введенному числу количества человек в ряду у противника, найдите количество человек в клину 
Пример входных данных: 9
Пример выходных данных: 25
Количество человек у противника может достигать 100
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
public class War
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

        var solution = new War();
        solution.Computation(response);
    }
    public string Computation(string response)

    {
        var input = Convert.ToInt32(string.Join("", response.Skip(response.IndexOf(' ', 0)).Where(ch => Char.IsDigit(ch))));
        var sum = 0;
        while (input >= 2 || input >= 1)
        {
            sum += input;
            input = input - 2;
        }
        response = sum.ToString();

        Console.WriteLine(response);
        return response;
    }
}
