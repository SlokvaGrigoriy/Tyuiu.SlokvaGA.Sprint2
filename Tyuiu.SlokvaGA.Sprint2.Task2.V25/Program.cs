using Tyuiu.SlokvaGA.Sprint2.Task2.V25.Lib;

namespace Tyuiu.SlokvaGA.Sprint2.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                               *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #25                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений                               *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать, но         *");
            Console.WriteLine("* использовать один раз в выражении) и логических операций (|, &, ||,    *");
            Console.WriteLine("* &&, !, ^, последовательность операций не должна нарушаться), а также   *");
            Console.WriteLine("* арифметических выражений,которая вернет логическую                     *");
            Console.WriteLine("* последовательность(массив):(False, False, True, False, True, False),   *");
            Console.WriteLine("* при a = 654, b = 325, c = 154, d = 333                       	      	*");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (res)
                Console.WriteLine("Точка находиться в заштрихованной области");
            else
                Console.WriteLine("Точка не находиться в заштрихованной области");
            Console.ReadKey();
        }
    }
}