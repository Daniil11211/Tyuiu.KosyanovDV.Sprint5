using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KosyanovDV.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string path1 = "Tyuiu.KosyanovDV.Sprint5";
            string path2 = "Tyuiu.KosyanovDV.Sprint5.Task0.V30";
            string path3 = "bin";
            string path4 = "Debug"; 
            string path5 = "OutPutFileTask0.txt";
            string directory = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(directory, path1, path2, path3, path4, path5);
            double res = Math.Round(((Math.Pow(x, 2) + 1) / (3 * x + 4)), 3);
            File.WriteAllText(fullPath, Convert.ToString(res));
            return fullPath;
        }
    }
}
