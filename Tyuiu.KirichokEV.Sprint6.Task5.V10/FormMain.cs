using Tyuiu.KirichokEV.Sprint6.Task5.V10.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Sveta\AppData\Local\Temp\DataSprint5\InPutDataFileTask5V10.txt";
        private void buttonPerform_KEV_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KEV.ColumnCount = 2;
            dataGridViewNums_KEV.Columns[0].Width = 20;
            dataGridViewNums_KEV.Columns[1].Width = 50;

            this.chartDiag_KEV.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiag_KEV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_KEV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KEV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_KEV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSave_KEV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы РППб-24-1 Киричок Елизавета Викторовна", "Ошибка");
        }
    }
}
