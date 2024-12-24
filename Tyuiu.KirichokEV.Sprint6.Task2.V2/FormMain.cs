using Tyuiu.KirichokEV.Sprint6.Task2.V2.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task2.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonPerform_KEV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KEV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KEV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KEV.Titles.Add("График функции");

                this.chartFunction_KEV.chartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_KEV.chartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KEV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[1]));
                    this.chartFunction_KEV.Series[0].Points.AddXY(startStep, valueArray[1]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPerform_KEV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPerform_KEV.BackColor = Color.Blue;
        }

        private void buttonPerform_KEV_MouseLeave(object sender, EventArgs e)
        {
            buttonPerform_KEV.BackColor = Color.Green;
        }

        private void buttonPerform_KEV_MouseEnter(object sender, EventArgs e)
        {
            buttonPerform_KEV.BackColor = Color.Black;
        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы РППб-24-1 Киричок Елизавета Викторовна", "Ошибка");
        }
    }
}
