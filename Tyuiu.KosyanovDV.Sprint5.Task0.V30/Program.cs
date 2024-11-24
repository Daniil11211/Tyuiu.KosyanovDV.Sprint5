using Tyuiu.KosyanovDV.Sprint5.Task0.V30.Lib;

namespace Tyuiu.KosyanovDV.Sprint5.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Класс File. Запись текстовых данных в файл              *");
            Console.WriteLine("* Задание #0                                                    *");
            Console.WriteLine("* Вариант #30                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дана формула. Посчитать значение при x = 3 и записать в файл. *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой                     *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*         2                                                     *");
            Console.WriteLine("*        x  + 1                                                 *");
            Console.WriteLine("* y = ------------                                              *");
            Console.WriteLine("*      3 * x + 4                                                *");
            Console.WriteLine("*****************************************************************");

            int x = 3;

            Console.WriteLine($"* x = {x}                                                       *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* Файл: {ds.SaveToFileTextData(x)}                                    *");
            Console.WriteLine($"* Создан!                                                             *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}
