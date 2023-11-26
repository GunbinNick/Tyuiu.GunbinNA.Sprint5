using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint5.Task7.V8.Lib;
using System.IO;

namespace Tyuiu.GunbinNA.Sprint5.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("*Задание #5.7                                                             *");
            Console.WriteLine("*Вариант #8                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан файл С:|DataSprint5|InPutDataFileTask7V8.txt (файл взять из архива   *");
            Console.WriteLine("*согласно вашему варианту. Создать папку в ручную С:|DataSprint5| и       *");
            Console.WriteLine("*скопировать в неё файл) в котором есть набор символьных данных. Заменить *");
            Console.WriteLine("*все заглавные русские буквы на строчные.Полученный результат сохранить   *");
            Console.WriteLine("*в файл OutPutDataFileTask7V8.txt                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V8.txt";
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V8.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
