/* Дарлин взламывает тумбочку в квартире Эллиота.  

Замочна скважина устроена из барьеров, которые не позволяют сдвинуть замок, эти барьеры соответствуют прорезям на ключе. 

Когда ключ поворачивается, он поворачивает то пространство где нет барьеров. 
На картинке барьеры показаны розовым цветом. 
Дарлин замерила расстояние от входа в замочную скважину, до начала каждого барьера, они равны целым числам. 
Чтобы взломать замок, достаточно вставить в каждый промежуток между барьерами, а так же до первого барьера и после последнего палочки диаметром 1 и повернуть их одновременно. 
Расстояние между барьерами во входных данных не может быть меньше чем 1. Каждый барьер толщиной 1.
Барьеров может быть от 1 до 3. Ваша задача вывести модель самодельного ключа Дарлин. Где каждая палочка будет надета на основу, равную длине замка, 
каждая палочка высотой 3, в каждом промежутке между барьерами каждая палочка будет ближе к правой стороне. 
Для примера модель ключа из рисунка: 
X0X00X0X
X0X00X0X 
X0X00X0X 
XXXXXXXX
Входные данные: расстояния от начала замочной скважины, до каждого барьера, и общая длина замочной скважины
Пример выходных данных: 
1,3,6,8
Выходные данные: нарисованная модель ключа Дарлин. Где X - ключ, 0 - пустое пространство.  
Пример выходных данных: 
X0X00X0X
X0X00X0X 
X0X00X0X 
XXXXXXXX
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
public class BreakingDoor
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

        var solution = new BreakingDoor();
        solution.Breaking(response);
    }
    public string Breaking(string response)

    {
        var map = string.Join("", response.Skip(response.IndexOf(' ') + 1)).Split(',').Select(s => Convert.ToInt32(s)).ToArray();
        var key = new StringBuilder();
        var bottom = new string('X', map[map.Length - 1]);
        key.Append(bottom);

        for (int i = 0; i < map.Length - 1; i++)
        {
            key[map[i]] = '0';
        }
        for (int i = 0; i <= key.Length - 2; i++)
        {
            if (key[i] == 'X' && key[i + 1] == 'X')
            {
                key[i] = '0';
            }
        }
        response = key.ToString();
        for (int i = 0; i < 2; i++)
        {
            response += "\n";
            response += key.ToString();
        }
        response += "\n";
        response += bottom;

        Console.WriteLine(response);
        return response;
    }
}