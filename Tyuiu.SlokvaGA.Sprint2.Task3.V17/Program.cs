using Tyuiu.SlokvaGA.Sprint2.Task3.V17.Lib;

namespace Tyuiu.SlokvaGA.Sprint2.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Слоква Г. А. | ИСПб-25-1"; 
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                    *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y     *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит   *");
            Console.WriteLine("* переменной X с клавиатуры.                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение функции y = " + res);
            Console.ReadKey();
        }
    }
}
