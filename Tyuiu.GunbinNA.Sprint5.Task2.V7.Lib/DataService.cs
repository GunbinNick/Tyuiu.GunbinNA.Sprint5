using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.GunbinNA.Sprint5.Task2.V7.Lib
{
    public class DataService : ISprint5Task2V7
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{ Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            FileInfo fi = new FileInfo(path);
            bool fileex = fi.Exists;
            if (fileex)
                File.Delete(path);

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        matrix[i, j] = 0;
                }
            }

            string strm = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        strm = strm + matrix[i, j] + ";";
                    else
                        strm = strm + matrix[i, j];


                    if (i != rows - 1)
                        File.AppendAllText(path, strm + Environment.NewLine);
                    else
                        File.AppendAllText(path, strm);

                    strm = "";
                }
            }

            return path;
        }
    }
}
