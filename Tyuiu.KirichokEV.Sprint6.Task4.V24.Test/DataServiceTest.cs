﻿using Tyuiu.KirichokEV.Sprint6.Task4.V24.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Sveta\AppData\Local\Temp\OutPutFileTask4V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
