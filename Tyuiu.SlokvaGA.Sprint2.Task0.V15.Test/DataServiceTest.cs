using Tyuiu.SlokvaGA.Sprint2.Task0.V15.Lib;
namespace Tyuiu.SlokvaGA.Sprint2.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, true, true, false, false };
            s
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
