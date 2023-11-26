using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task6.V19.Lib;

namespace Tyuiu.GunbinNA.Sprint5.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Тема: Обработка текстовых файлов                                         *");
            Console.WriteLine("*Задание #5.6                                                             *");
            Console.WriteLine("*Вариант #19                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан файл С:|DataSprint5|InPutDataFileTask6V19.txt (файл взять из архива  *");
            Console.WriteLine("*согласно вашему варианту. Создать папку в ручную С:|DataSprint5| и       *");
            Console.WriteLine("*скопировать в неё файл) в котором есть набор символьных данных. Найти    *");
            Console.WriteLine("*количество двузначных чисел в заданной строке.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask6V19.txt";

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
