using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SlokvaGA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d) => 
        k < 1 || k > 365 ? throw new ArgumentException("Ошибка. k = (1;365)")
        : ((d + k - 2) % 7 + 1) switch
        {
            1 => "Понедельник",
            2 => "Вторник", 
            3 => "Среда",
            4 => "Четверг",
            5 => "Пятница",
            6 => "Суббота",
            7 => "Воскресенье",
            _ => throw new ArgumentException("Ошибка. d = (1;7)")
        };
    }
}