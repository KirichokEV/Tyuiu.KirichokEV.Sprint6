﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KirichokEV.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x)) / (x + 12) - Math.Sin(x) * 2 - 2*x, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
