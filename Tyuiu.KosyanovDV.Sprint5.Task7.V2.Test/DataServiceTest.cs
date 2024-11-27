using Tyuiu.KosyanovDV.Sprint5.Task7.V2.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\kosya\AppData\Local\Temp\OutPutFileTask7V2.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}