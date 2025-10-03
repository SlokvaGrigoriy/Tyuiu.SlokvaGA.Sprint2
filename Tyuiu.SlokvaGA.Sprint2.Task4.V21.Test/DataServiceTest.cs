﻿using Tyuiu.SlokvaGA.Sprint2.Task4.V21.Lib;
namespace Tyuiu.SlokvaGA.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 87,08;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
