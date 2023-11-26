using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task4.V13.Lib;

namespace Tyuiu.GunbinNA.Sprint5.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Тема: Чтение данных из текстового файла                                  *");
            Console.WriteLine("*Задание #5.4                                                             *");
            Console.WriteLine("*Вариант #13                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан файл С:|DataSprint5|InPutDataFileTask4V0.txt (файл взять из архива   *");
            Console.WriteLine("*согласно вашему варианту. Создать папку в ручную С:|DataSprint5| и       *");
            Console.WriteLine("*скопировать в неё файл) в котором есть вещественное значение. Прочитать  *");
            Console.WriteLine("*значение из файла и подставить вместо Х в формуле y = cos(x) + x^2/2.    *");
            Console.WriteLine("*Вычислить значение по формуле (Полученное значение округлить до трех     *");
            Console.WriteLine("*знаков после запятой) и вернуть полученный результат на консоль.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask4V13.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
