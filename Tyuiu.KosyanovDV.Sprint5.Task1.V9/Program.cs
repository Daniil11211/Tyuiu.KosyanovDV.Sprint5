using Tyuiu.KosyanovDV.Sprint5.Task1.V9.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task1.V9
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
            Console.WriteLine("* Задание #1                                                    *");
            Console.WriteLine("* Вариант #9                                                    *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дана формула. Посчитать значения на отрезке [-5; 5] и         *");
            Console.WriteLine("* записать в файл. Произвести проверку деления на 0 Ответ       *");
            Console.WriteLine("* округлить до 2 знаков после запятой                           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*         2                                                     *");
            Console.WriteLine("*               cos(x)                                          *");
            Console.WriteLine("* y = sin(x) + -------- - 1,5 * x                               *");
            Console.WriteLine("*                  2                                            *");
            Console.WriteLine("*****************************************************************");

            int start = -5;
            int end = 5;

            Console.WriteLine($"* Отрезок: [{start};{end}]                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* Файл: {ds.SaveToFileTextData(start, end)} ");
            Console.WriteLine($"* Создан!                                                             *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}
