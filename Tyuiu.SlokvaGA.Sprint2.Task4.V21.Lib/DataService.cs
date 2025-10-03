using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SlokvaGA.Sprint2.Task4.V21.Lib
{
    public class DataService : ISprint2Task4V21
    {
        public double Calculate(double x, double y)
        {
            double z = x < y - 2 ? Math.Pow(2 + ((x + 1) / Math.Pow(x, 2)), y) : (Math.Pow(x, 2) + 10) / (Math.Pow(y, 2) - Math.Sin(x * x) + 12);
            return Math.Round(z, 3);
        }
    }
}
