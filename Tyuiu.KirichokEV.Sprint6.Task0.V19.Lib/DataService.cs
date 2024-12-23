using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KirichokEV.Sprint6.Task0.V19.Lib
{
    public class DataService : ISprint6Task0V19
    {
        public double Calculate(int x)
        {
            double res = ((-0.25) * (Math.Pow((double)x, 3) - 3 * Math.Pow((double)x, 2) + 4));
            return Math.Round(res, 3);

        }
    }
}
