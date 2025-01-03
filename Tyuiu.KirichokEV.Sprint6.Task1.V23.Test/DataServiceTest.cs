﻿using Tyuiu.KirichokEV.Sprint6.Task1.V23.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 3.3;
            valueWaitArray[1] = -12.37;
            valueWaitArray[2] = -14.02;
            valueWaitArray[3] = -5.57;
            valueWaitArray[4] = 0.65;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = -0.65;
            valueWaitArray[7] = 5.57;
            valueWaitArray[8] = 14.02;
            valueWaitArray[9] = 12.37;
            valueWaitArray[10] = -3.3;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
