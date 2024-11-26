using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyanovDV.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            
            string[] strings = text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> res = new List<double>();

            foreach (string s in strings)
            {
                if (int.TryParse(s.Trim(), out int number) && number % 4 == 0)
                {
                    res.Add(number);
                }
            }

            if (res.Count == 0)
            {
                throw new InvalidOperationException("Не найдено подходящих целых чисел, кратных 4.");
            }

            double minNumber = res.Min();

            return Math.Round(minNumber, 3);

        }
    }
}