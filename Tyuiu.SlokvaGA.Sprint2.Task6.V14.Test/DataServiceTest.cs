using Tyuiu.SlokvaGA.Sprint2.Task6.V14.Lib;
namespace Tyuiu.SlokvaGA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindDayName()
        {
            DataService ds = new DataService();
            int k = 1;
            int d = 2;
            Assert.AreEqual("вторник", ds.FindDayName(k, d));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(0, 4);
            });
        }
    }
}

