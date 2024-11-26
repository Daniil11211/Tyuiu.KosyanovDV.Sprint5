using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;

namespace Tyuiu.KosyanovDV.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.cvs");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist) { File.Delete(path); }

            double res = Math.Round(Math.Log((x + 1) / (double)(x + 2)), 2);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }

            return path;
        }
    }
}
