using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.GunbinNA.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);

            double y = Math.Round(Math.Cos(Convert.ToDouble(strx)) + (Math.Pow(Convert.ToDouble(strx), 2)/2), 3);

            return y;
        }
    }
}
