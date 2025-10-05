using Tyuiu.SlokvaGA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.SlokvaGA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            // Тест 1: Обычный случай (5 июня 2002 -> 6 июня 2002)
            int n = 5;
            int m = 6;
            int g = 2002;
            Assert.AreEqual("6 6 2002", ds.FindDateOfNextDay(g, m, n));

            // Тест 2: Конец месяца (30 июня 2002 -> 1 июля 2002)
            Assert.AreEqual("1 7 2002", ds.FindDateOfNextDay(2002, 6, 30));

            // Тест 3: Конец года (31 декабря 2002 -> 1 января 2003)
            Assert.AreEqual("1 1 2003", ds.FindDateOfNextDay(2002, 12, 31));

            // Тест 4: Февраль високосного года (28 февраля 2004 -> 29 февраля 2004)
            Assert.AreEqual("29 2 2004", ds.FindDateOfNextDay(2004, 2, 28));

            // Тест 5: Конец февраля високосного года (29 февраля 2004 -> 1 марта 2004)
            Assert.AreEqual("1 3 2004", ds.FindDateOfNextDay(2004, 2, 29));

            // Тесты на исключения
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2002, 13, 1); // Неверный месяц
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2002, 6, 31); // Неверный день (в июне 30 дней)
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2002, 2, 30); // Неверный день (в феврале максимум 29)
            });
        }
    }
}

