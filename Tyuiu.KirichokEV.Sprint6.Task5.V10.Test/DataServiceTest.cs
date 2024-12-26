
using Tyuiu.KirichokEV.Sprint6.Task5.V10.Lib;
using System.IO;

namespace Tyuiu.KirichokEV.Sprint6.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
