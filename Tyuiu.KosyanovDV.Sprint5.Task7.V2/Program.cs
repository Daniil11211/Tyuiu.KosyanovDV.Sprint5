using Tyuiu.KosyanovDV.Sprint5.Task7.V2.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту       *");
            Console.WriteLine("* Задание #7                                                    *");
            Console.WriteLine("* Вариант #2                                                    *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дана строка. Заменить в ней все цифры на #. Результат         *");
            Console.WriteLine("* сохранить в файл                                              *");


            string path = @"C:\DataSprint5\InPutDataFileTask7V2.txt";

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* Файл: {ds.LoadDataAndSave(path)} ");
            Console.WriteLine($"* Создан!                                                       *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}