using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GunbinNA.Sprint5.Task7.V8.Lib;
namespace Tyuiu.GunbinNA.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V8.txt";
            FileInfo fi = new FileInfo(path);
            bool fileex = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
