using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SlokvaGA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            // Проверка корректности номера месяца
            if (m < 1 || m > 12)
                throw new ArgumentException($"Ошибка. Неверно указан месяц (от 1 до 12). Значение: {m}");

            // Определение количества дней в месяце
            int dinm;
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    dinm = 30;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dinm = 31;
                    break;
                case 2:
                    dinm = 29; // Високосный год
                    break;
                default:
                    dinm = -1; // Недопустимый месяц
                    break;
            }

            // Проверка корректности дня
            if (n < 1 || n > dinm)
                throw new ArgumentException($"Ошибка. Неверно указан день. Значение: {n}");

            // Вычисление следующей даты
            int nd = n + 1;
            int nm = m;
            int ny = g;

            if (nd > dinm)
            {
                nd = 1;
                nm++;
                if (nm > 12)
                {
                    nm = 1;
                    ny++;
                }
            }

            // Получение названия месяца
            string monthName;
            switch (nm)
            {
                case 1: monthName = "Январь"; break;
                case 2: monthName = "Февраль"; break;
                case 3: monthName = "Март"; break;
                case 4: monthName = "Апрель"; break;
                case 5: monthName = "Май"; break;
                case 6: monthName = "Июнь"; break;
                case 7: monthName = "Июль"; break;
                case 8: monthName = "Август"; break;
                case 9: monthName = "Сентябрь"; break;
                case 10: monthName = "Октябрь"; break;
                case 11: monthName = "Ноябрь"; break;
                case 12: monthName = "Декабрь"; break;
                default: monthName = "Неизвестно"; break;
            }

            return $"{nd} {monthName} {ny}";
        }
    }
}