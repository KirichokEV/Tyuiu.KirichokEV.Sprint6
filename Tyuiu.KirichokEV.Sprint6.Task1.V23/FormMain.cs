using Tyuiu.KirichokEV.Sprint6.Task1.V23.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task1.V23
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KEV.Text = "";
                textBoxResult_KEV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KEV.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_KEV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 5:f2}    | ", startStep, valueArray[i]);
                    textBoxResult_KEV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KEV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы РППб-24-1 Киричок Елизавета Викторовна", "Ошибка");
        }
    }
}
