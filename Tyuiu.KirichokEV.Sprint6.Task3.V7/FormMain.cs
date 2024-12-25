using Tyuiu.KirichokEV.Sprint6.Task3.V7.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 31, 25, -18, 12, 9 },
                                          { 6, 34, -2, 2, -18  },
                                          { -5, 4, 27, 4, -1   },
                                          { 4, 15, 34, -6, -10 },
                                          { 0, 8, 5, 14, -17   } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_KEV.ColumnCount = columns;
            dataGridViewMatrix_KEV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KEV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KEV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonPerform_KEV_Click(object sender, EventArgs e)
        {
            dataGridViewMtrx_KEV.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы РППб-24-1 Киричок Елизавета Викторовна", "Ошибка");
        }
    }
}
