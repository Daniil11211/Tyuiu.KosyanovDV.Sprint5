using Tyuiu.KosyanovDV.Sprint5.Task4.V15.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task4.V15
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
            Console.WriteLine("* Задание #4                                                    *");
            Console.WriteLine("* Вариант #15                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дано выражение. Вычислить его значение при  таком x,          *");
            Console.WriteLine("* записанном в файле. Ответ округлить до 3 знаков после запятой *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                2                                              *");
            Console.WriteLine("*               x                                               *");
            Console.WriteLine("* y = sin(x) + ----                                             *");
            Console.WriteLine("*               2                                               *");

            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.LoadFromDataFile(path)} ");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}