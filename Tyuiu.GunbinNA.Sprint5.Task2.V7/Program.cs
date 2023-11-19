using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task2.V7.Lib;

namespace Tyuiu.GunbinNA.Sprint5.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Тема: Класс File. Запись структурированных данных в текстовый файл       *");
            Console.WriteLine("*Задание #5.2                                                             *");
            Console.WriteLine("*Вариант #7                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан двумерный целочисленный массив 3 на 3 элементов, заполненный         *");
            Console.WriteLine("*значениями с клавиатуры. Заменить нечетные элементы массива на 0.        *");
            Console.WriteLine("*Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int rows, columns;
            Console.Write("Введите кол-во строк массива: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов массива: ");
            columns = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, columns];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите значение {i},{j} элемента массива: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(array);
            Console.WriteLine(res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
