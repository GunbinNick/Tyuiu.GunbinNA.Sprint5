using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GunbinNA.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string forsplit = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    forsplit += line;                   
                }
            }
            string[] splited = forsplit.Split(' ');

            int value = 0;
            for (int j = 0; j < splited.Length; j++)
            {
                bool splity = int.TryParse(splited[j], out value);
                if ((splity) && (value / 100 < 1) && !(value / 10 < 1))
                    count++;
            }
            return count;
        }
    }
}
