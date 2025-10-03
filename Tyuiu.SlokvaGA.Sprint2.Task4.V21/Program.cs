using Tyuiu.SlokvaGA.Sprint2.Task4.V21.Lib;

namespace Tyuiu.SlokvaGA.Sprint2.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Слоква Г. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Тернарный оператор                                               *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #21                                                            *");
            Console.WriteLine("* Выполнил: Слоква Г. А. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, вычисляет требуемое значение с использованием      *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x, y *");
            Console.WriteLine("* с клавиатуры, если x < y - 2,то                                        *");
            Console.WriteLine("*           x+1                 x^2+10                                   *");
            Console.WriteLine("*  z = (2 + --- )^2, иначе   -------------                               *");
            Console.WriteLine("*           x^2              y^2-sinx^2+12                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение функции z = " + res);
            Console.ReadKey();
        }
    }
}
