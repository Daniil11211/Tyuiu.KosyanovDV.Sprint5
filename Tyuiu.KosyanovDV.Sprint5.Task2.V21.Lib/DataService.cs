using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyanovDV.Sprint5.Task2.V21.Lib
{
    public class DataService : ISprint5Task2V21
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.cvs");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist) { File.Delete(path); }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    if (j != columns)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }

            return path;
        }
    }
}
