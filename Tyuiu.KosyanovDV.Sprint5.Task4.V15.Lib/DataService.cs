using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyanovDV.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string read = File.ReadAllText(path);
            double res = Math.Round((Math.Sin(Convert.ToDouble(read)) + ((Math.Pow(Convert.ToDouble(read), 2)) / (2))), 3);
            return res;
        }
    }
}
