/* Задание:
Эллиот хочет получить все имена и фамилии. Для этого он находит все пары слов, которые идут друг за другом, и начинаются с заглавной буквы, 
причем далее в слове могут быть только русские буквы. Напишите программу способную это сделать. 
Если между двумя подходящими словами стоит любой знак кроме пробела, то эту пару слов не считать Именем Фамилией. 
Входные данные представлены на русском языке и исключают возможность появления трех и более слов, удовлетворяющих условию поиска, подряд. 
Текст длиной не более 2000 символов
Могут встречаться повторяющиеся пробелы, в таком случае подходящая пара остается Именем и Фамилией. Имя и фамилию ищите на русском языке. 
Пример входных данных: 
“В качестве выкупа fsociety вынуждает Скотта Ноулза надеть маску fsociety и публично сжечь 5,9 миллиона долларов полученных от взлома. 
Анджела Мосс продолжает подниматься по карьерной лестнице в E Corp, по-видимому, довольная своей новой корпоративной позицией, и, похоже, отказывается от иска. 
Джоанна получает подарок на пороге - музыкальную шкатулку со спрятанным под ней телефоном, но пропускает звонок. 
Эллиот обнаруживает, что действовал под влиянием Мистера Робота, когда думал, что спит. Человек по имени Брок убивает Гидеона, 
который ранее угрожал сообщить о подозрительном поведении Эллиота в Олсейф ФБР и агенту Доминик ДиПьерро. 
Эллиот просыпается от диссоциативного состояния, разговаривая по телефону, его приветствует на другом конце провода Тайрелл.”
Пример выходных данных: “Скотта Ноулза, Анджела Мосс, Мистера Робота, Олсейф ФБР, Доминик ДиПьерро”
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

public class FirstNameLastName
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

        var solution = new FirstNameLastName();
        solution.Searching(response);
    }
    public string Searching(string response)

    {
        var input = string.Join(" ", response.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        var regex = new Regex(@"[^-][А-ЯЁ]\w{1}[А-яЁё]\w*\s+[А-ЯЁ]\w{1}[А-яЁё]\w*", RegexOptions.Compiled);
        var matches = regex.Matches(input);
        var map = new List<string>();
        foreach (Match match in matches)
        {   
            map.Add(match.Value); 
        }

        response = string.Join(",", map).Trim(' ').TrimEnd(',');

        Console.WriteLine(response);
        return response;
    }
}
