namespace Tyuiu.KosyanovDV.Sprint5.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\kosya\AppData\Local\Temp\OutPutFileTask2.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}