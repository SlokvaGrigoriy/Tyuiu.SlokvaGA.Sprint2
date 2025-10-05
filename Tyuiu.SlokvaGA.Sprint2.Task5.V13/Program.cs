using Tyuiu.SlokvaGA.Sprint2.Task5.V13.Lib;

namespace Tyuiu.SlokvaGA.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #13                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:        *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                      *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                   *");
            Console.WriteLine("* Заданный год является високосным.                                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите число: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDateOfNextDay(year, month, date);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Следующий день: " + res);
            Console.ReadKey();
        }
    }
}
