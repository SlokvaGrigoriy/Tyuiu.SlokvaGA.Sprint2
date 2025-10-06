using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SlokvaGA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d) => ((d + k - 2) % 7 + 1) switch
        {
            1 => "понедельник",
            2 => "вторник",
            3 => "среда",
            4 => "четверг",
            5 => "пятница",
            6 => "суббота",
            7 => "воскресенье",
            _ => throw new ArgumentException("Ошибка. k = (1;365)")
        };
    }
}