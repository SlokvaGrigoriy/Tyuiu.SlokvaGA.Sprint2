using Tyuiu.SlokvaGA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.SlokvaGA.Sprint2.Task6.V14
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
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели      *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем)               *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января d-й день     *");
            Console.WriteLine("* недели (если 1 января — понедельник, то d = 1 , если вторник — d = 2 , *");
            Console.WriteLine("*  …, если воскресенье — d = 7).                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите день: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDayName(month, date);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Следующий день: " + res);
            Console.ReadKey();
        }
    }
}
