using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SlokvaGA.Sprint2.Task4.V21.Lib
{
    public class DataService : ISprint2Task4V21
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(x > y - 2 ? (2 + ((x+1 / Math.Pow((Math.Pow(x, 2)), y)))) : ((Math.Pow(x, 2) + 10) / ((Math.Pow(x, 2) + 10) / (Math.Pow(y, 2) - Math.Pow(Math.Sin(x), 2) - 12))), 3);
        }
    }
}
