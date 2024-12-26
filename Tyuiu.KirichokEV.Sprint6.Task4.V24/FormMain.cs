using System.Windows.Forms;
using System.Xml;
using Tyuiu.KirichokEV.Sprint6.Task4.V24.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task4.V24
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

                this.chartFunction_KEV.ChartAreas[0].AxisX.Title = "��� �";
                this.chartFunction_KEV.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult_KEV.Text = "";
                chartFunction_KEV.Series[0].Points.Clear();
                for (int i = 0; i <= len; i++)
                {
                    this.chartFunction_KEV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KEV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KEV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V24.txt" });
                File.WriteAllText(path, textBoxResult_KEV.Text);

                DialogResult dialogResult = MessageBox.Show("����" + path + "�������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 ��������� ��������� ������ ����-24-1 ������� ��������� ����������", "������");
        }
    }
}
