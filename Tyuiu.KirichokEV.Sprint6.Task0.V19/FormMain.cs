using Tyuiu.KirichokEV.Sprint6.Task0.V19.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task0.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KEV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KEV.Text)));
            }
            catch
            {
                MessageBox.Show("Введенны неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxVarX_KEV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 0 || e.KeyChar >= 5) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonQuestion_KEV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РППб-24-1 Киричок Елизавета Вкиторовна", "Сообщение");
        }
    }
}
