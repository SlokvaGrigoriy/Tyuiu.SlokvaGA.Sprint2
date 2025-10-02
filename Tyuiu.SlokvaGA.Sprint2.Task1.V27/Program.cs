using Tyuiu.SlokvaGA.Sprint2.Task1.V27.Lib;

namespace Tyuiu.SlokvaGA.Sprint2.Task1.V27
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
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
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

            int a = 654;
            int b = 325;
            int c = 154;
            int d = 333;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
