using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task1.V2.Lib;

namespace Tyuiu.GunbinNA.Sprint5.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Тема: Класс File. Запись набора данных в текстовый файл                  *");
            Console.WriteLine("*Задание #5.1                                                             *");
            Console.WriteLine("*Вариант #2                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дана функция (2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6 (произвести *");
            Console.WriteLine("*табулирование) f(x) на заданном диапазоне [-5:5] с шагом 1. Произвести   *");
            Console.WriteLine("*проверку деления на ноль. При делении на ноль вернуть значение ноль.     *");
            Console.WriteLine("*Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на    *");
            Console.WriteLine("*консоль в таблицу. Значения округлить до двух знаков после запятой.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int end = 5;


            Console.WriteLine("startvalue = " + start);
            Console.WriteLine("stopvalue = " + end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(start, end);
            Console.WriteLine(res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
