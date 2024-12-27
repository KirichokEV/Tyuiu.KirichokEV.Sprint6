using Tyuiu.KirichokEV.Sprint6.Task7.V7.Lib;

namespace Tyuiu.KirichokEV.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_KEV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KEV.ShowDialog();
            openFilePath = openFileDialogTask_KEV.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewMatrix_KEV.ColumnCount = columns;
            dataGridViewMatrix_KEV.RowCount = rows;
            dataGridViewOutMatrix_KEV.ColumnCount = columns;
            dataGridViewOutMatrix_KEV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KEV.Columns[i].Width = 25;
                dataGridViewOutMatrix_KEV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMatrix_KEV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KEV.Enabled = true;
        }

        private void buttonPerform_KEV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_KEV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KEV.Enabled = true;
        }

        private void buttonSave_KEV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KEV.FileName = "OutPutFileTask7V7.csv";
            saveFileDialogMatrix_KEV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KEV.ShowDialog();

            string path = saveFileDialogMatrix_KEV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_KEV.RowCount;
            int columns = dataGridViewMatrix_KEV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_KEV.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_KEV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void duttonOpen_KEV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KEV.ToolTipTitle = "Открыть файл";
        }

        private void buttonPerform_KEV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KEV.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_KEV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KEV.ToolTipTitle = "Сохранить в файл";
        }

        private void buttomDone_KEV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KEV.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewMatrix_KEV.ColumnCount = 50;
            dataGridViewOutMatrix_KEV.ColumnCount = 50;

            dataGridViewMatrix_KEV.RowCount = 50;
            dataGridViewOutMatrix_KEV.RowCount = 50;

        }

        private void buttonDone_KEV_Click(object sender, EventArgs e)
        {
            FormAbout_KEV formAbout = new FormAbout_KEV();
            formAbout.ShowDialog();
        }
    }
}
