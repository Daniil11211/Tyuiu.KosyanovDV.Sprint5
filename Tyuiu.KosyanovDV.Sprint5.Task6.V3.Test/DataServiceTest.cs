using Tyuiu.KosyanovDV.Sprint5.Task6.V3.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";

            var res = ds.LoadFromDataFile(path);

            var wait = 21;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}