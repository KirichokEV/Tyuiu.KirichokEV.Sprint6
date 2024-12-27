using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KirichokEV.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;

            int temp;

            int column = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, column];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(";");
                for (int j = 0; j < column; j++)
                {
                    temp = int.Parse(values[j]);

                    if (i == 4 && temp % 2 != 0) matrix[i, j] = 66;
                    else matrix[i, j] = temp;
                }
            }
            return matrix;
        }
    }
}
