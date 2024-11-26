using Tyuiu.KosyanovDV.Sprint5.Task2.V21.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Класс File. Запись набора текстовых данных в файл       *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #21                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дана матрица 3х3. Заменить все нечётные элементы матрицы      *");
            Console.WriteLine("* на 0 и записать в файл                                        *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*  4; 8; 5                                                      *");
            Console.WriteLine("*  6; 3; 2                                                      *");
            Console.WriteLine("*  9; 4; 5                                                      *");
            Console.WriteLine("*****************************************************************");

            int[,] matrix = { { 4, 8, 5 }, { 6, 3, 2 }, { 9, 4, 5 } };

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* Файл: {ds.SaveToFileTextData(matrix)} ");
            Console.WriteLine($"* Создан!                                                      *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}