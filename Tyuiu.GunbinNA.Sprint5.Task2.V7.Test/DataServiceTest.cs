using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task2.V7.Lib;

namespace Tyuiu.GunbinNA.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint5\Tyuiu.GunbinNA.Sprint5.Task2.V7\bin\Debug\OutPutFileTask2.csv";
            FileInfo fi = new FileInfo(path);
            bool fileex = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
