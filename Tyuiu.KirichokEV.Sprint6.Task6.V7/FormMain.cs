using Tyuiu.KirichokEV.Sprint6.Task6.V7.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task6.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonPerform_KEV_Click(object sender, EventArgs e)
        {
            string str = " ";
            textBoxResult_KEV.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            FormAbout_KEV formAbout = new FormAbout_KEV();
            formAbout.ShowDialog();
        }

        private void buttonOpen_KEV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KEV.ShowDialog();
            openFilePath = openFileDialogTask_KEV.FileName;
            textBoxTextInput_KEV.Text = File.ReadAllText(openFilePath);
            buttonDone_KEV.Enabled = true;
        }
    }
}
