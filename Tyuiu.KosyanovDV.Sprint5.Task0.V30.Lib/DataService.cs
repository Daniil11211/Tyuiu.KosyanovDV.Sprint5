using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KosyanovDV.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string[] paths = { "D:", "Microsoft VS", "repos", "Tyuiu.KosyanovDV.Sprint5", "Tyuiu.KosyanovDV.Sprint5.Task0.V30", "bin", "Debug", "OutPutFileTask0.txt" };
            string fullPath = Path.Combine(paths);
            double res = Math.Round(((Math.Pow(x, 2) + 1) / (3 * x + 4)), 3);
            File.WriteAllText(fullPath, Convert.ToString(res));
            return fullPath;
        }
    }
}
