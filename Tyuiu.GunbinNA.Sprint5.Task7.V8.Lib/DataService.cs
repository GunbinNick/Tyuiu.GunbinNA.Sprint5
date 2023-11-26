using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GunbinNA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

            FileInfo fi = new FileInfo(pathSaveFile);
            bool fileex = fi.Exists;
            if (fileex)
                File.Delete(pathSaveFile);

            string strline = "";
            string pattern = "[а-яА-ЯёЁ]";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        bool reg = Regex.IsMatch(line, pattern);
                        if (reg == true)
                            strline += Char.ToLower(line[i]);
                    }

                    File.AppendAllText(pathSaveFile, strline + Environment.NewLine);
                    strline = "";
                }
            }
            return pathSaveFile;
        }
    }
}
