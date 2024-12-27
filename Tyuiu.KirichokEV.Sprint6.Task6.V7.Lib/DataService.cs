using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KirichokEV.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < resStr.Length; i += 3)
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            return resStr;
        }
    }
}
