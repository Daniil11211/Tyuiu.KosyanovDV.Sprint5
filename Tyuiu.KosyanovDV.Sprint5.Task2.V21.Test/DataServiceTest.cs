namespace Tyuiu.KosyanovDV.Sprint5.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"D:\Microsoft VS\repos\Tyuiu.KosyanovDV.Sprint5\Tyuiu.KosyanovDV.Sprint5.Task2.V21\bin\Debug\OutPutFileTask2.csv";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}