using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;

namespace Tyuiu.KosyanovDV.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist) { File.Delete(path); }

            double res = Math.Round(Math.Log((double)(x + 1) / (double)(x + 2)), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.Unicode))
            {
                writer.Write(res);
            }

            string result = Convert.ToString(res);

            return result;
        }
    }
}
