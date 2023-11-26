using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task6.V19.Lib;

namespace Tyuiu.GunbinNA.Sprint5.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            FileInfo fi = new FileInfo(path);
            bool fileex = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }

        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
