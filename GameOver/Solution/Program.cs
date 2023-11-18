﻿/* Задание: 
Бернард смотрит, что происходит в парке в разные моменты времени. Он хочет знать в каком состоянии находились машины в нужное ему время. 
Они находятся в двух состояниях либо они играют GAME CONTINUES. Либо они находятся на починке GAME OVER
Вам будут даны интервалы времени, когда роботы находились на починке, и время, которое интересовало Бернарда. 
Бернард смотрит данные за последний месяц. Поэтому он вводит число и время. Например 2 -е число, 15 часов 13 минут:   2 15:13
Входные данные: Сначала идёт список роботов в виде: Имя | даты поломки через запятую в виду "DD HH:MM"
Потом идёт список времени, которое интересовало Бернарда в формате "DD HH:MM". Кол-во роботов не превышает 10, кол-во дат в запросе не больше 10
Время ремонта робота включает в себя границы заданных промежутков времени. Добавлен идентификатор строки R - роботы, T - время
Пример входных данных:
R:Тедди| 4 18:12 - 6 19:32, 17 13:12 - 20 14:42
R:Долорес| 12 14:12 - 12 18:15
R:Мейв| 13 9:21 - 13 21:23, 14 7:23 - 15 12:12 , 17 18:00 - 19 23:22, 22 20:25 - 26 15:14  
R:Питер| 8 9:05 - 10 4:55
R:Клементина| 15 4:00 - 16 14:43
T:8 14:21
T:17 19:17
Выходные данные: дата, состояния роботов
Пример выходных данных: 
8 14:21
Тедди GAME CONTINUES
Долорес GAME CONTINUES
Мейв GAME CONTINUES
Питер GAME OVER
Клементина GAME CONTINUES
17 19:17
Тедди GAME OVER
Долорес GAME CONTINUES
Мейв GAME OVER
Питер GAME CONTINUES
Клементина GAME CONTINUES
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class GameOver
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

        var solution = new GameOver();
        solution.DetermineCondition(response);
    }
    public string DetermineCondition(string response)

    {
        var timeCondition = new List<string>();
        var robots = new Dictionary<string, string>();
        var stateCondition = new List<string>();
        var regexT = new Regex(@"(T:)([0-9]{1,2} [0-9]{1,2}:[0-9]{2})", RegexOptions.Multiline);
        var matchesT = regexT.Matches(response);
        foreach (Match match in matchesT)
        {
            timeCondition.Add(match.Groups[2].Value);
        }

        var regexR = new Regex(@"(R:)([А-яЁё]\w+)\| (([0-9]{1,2} [0-9]{1,2}:[0-9]{2} - [0-9]{1,2} [0-9]{1,2}:[0-9]{2}\s*,*\s*)+)", RegexOptions.Multiline);
        var matchesR = regexR.Matches(response);
        foreach (Match match in matchesR)
        {
            robots.Add(match.Groups[2].Value, match.Groups[3].Value);
        }
        foreach (var item in timeCondition)
        {
            stateCondition.Add(item);
            foreach (KeyValuePair<string, string> robot in robots)
            {
                stateCondition.Add(robots.Key);
                
            }
        }
            
        response = string.Join(",", stateCondition).Trim(' ').TrimEnd(',');

        Console.WriteLine(response);
        return response;
    }
}

