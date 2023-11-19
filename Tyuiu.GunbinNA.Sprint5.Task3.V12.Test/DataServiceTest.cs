using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task3.V12.Lib;

namespace Tyuiu.GunbinNA.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint5\Tyuiu.GunbinNA.Sprint5.Task3.V12\bin\Debug\OutPutFileTask3.bin";
            FileInfo fi = new FileInfo(path);
            bool fileex = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
