using Tyuiu.KosyanovDV.Sprint5.Task5.V22.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                       *");
            Console.WriteLine("* Задание #5                                                    *");
            Console.WriteLine("* Вариант #22                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дан набор значений. Найти из него наименьшее, кратное 4       *");

            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.LoadFromDataFile(path)} ");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}