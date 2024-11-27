using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyanovDV.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            int count = 0;

            foreach (char c in text)
            {
                if (alphabet.Contains(c))
                {
                    count++;
                }
            }

            if (count == 0)
            {
                throw new InvalidOperationException("Не найдено латинских букв.");
            }

            return count;
        }
    }
}
