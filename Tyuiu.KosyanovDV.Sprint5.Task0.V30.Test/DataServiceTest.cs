namespace Tyuiu.KosyanovDV.Sprint5.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"D:\Microsoft VS\repos\Tyuiu.KosyanovDV.Sprint5\Tyuiu.KosyanovDV.Sprint5.Task0.V30\bin\Debug\OutPutFileTask0.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}