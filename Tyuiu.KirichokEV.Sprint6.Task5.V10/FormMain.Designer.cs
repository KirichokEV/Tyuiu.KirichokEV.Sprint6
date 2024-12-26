namespace Tyuiu.KirichokEV.Sprint6.Task5.V10
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelOne_KEV = new Panel();
            buttonSave_KEV = new Button();
            buttonDone_KEV = new Button();
            buttonPerform_KEV = new Button();
            textBoxTerm_KEV = new TextBox();
            textBoxCondition_KEV = new TextBox();
            panel1 = new Panel();
            dataGridViewNums_KEV = new DataGridView();
            textBoxInput_KEV = new TextBox();
            chartDiag_KEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelOne_KEV.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KEV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KEV).BeginInit();
            SuspendLayout();
            // 
            // panelOne_KEV
            // 
            panelOne_KEV.Controls.Add(buttonSave_KEV);
            panelOne_KEV.Controls.Add(buttonDone_KEV);
            panelOne_KEV.Controls.Add(buttonPerform_KEV);
            panelOne_KEV.Controls.Add(textBoxTerm_KEV);
            panelOne_KEV.Controls.Add(textBoxCondition_KEV);
            panelOne_KEV.Dock = DockStyle.Top;
            panelOne_KEV.Location = new Point(0, 0);
            panelOne_KEV.Name = "panelOne_KEV";
            panelOne_KEV.Size = new Size(1184, 104);
            panelOne_KEV.TabIndex = 0;
            // 
            // buttonSave_KEV
            // 
            buttonSave_KEV.Location = new Point(971, 27);
            buttonSave_KEV.Name = "buttonSave_KEV";
            buttonSave_KEV.Size = new Size(112, 65);
            buttonSave_KEV.TabIndex = 4;
            buttonSave_KEV.Text = "Сохранить ";
            buttonSave_KEV.UseVisualStyleBackColor = true;
            buttonSave_KEV.Click += buttonSave_KEV_Click;
            // 
            // buttonDone_KEV
            // 
            buttonDone_KEV.Location = new Point(832, 27);
            buttonDone_KEV.Name = "buttonDone_KEV";
            buttonDone_KEV.Size = new Size(112, 65);
            buttonDone_KEV.TabIndex = 3;
            buttonDone_KEV.Text = "Открыть ";
            buttonDone_KEV.UseVisualStyleBackColor = true;
            buttonDone_KEV.Click += buttonDone_KEV_Click;
            // 
            // buttonPerform_KEV
            // 
            buttonPerform_KEV.Location = new Point(693, 27);
            buttonPerform_KEV.Name = "buttonPerform_KEV";
            buttonPerform_KEV.Size = new Size(112, 65);
            buttonPerform_KEV.TabIndex = 2;
            buttonPerform_KEV.Text = "Выполнить ";
            buttonPerform_KEV.UseVisualStyleBackColor = true;
            buttonPerform_KEV.Click += buttonPerform_KEV_Click;
            // 
            // textBoxTerm_KEV
            // 
            textBoxTerm_KEV.Location = new Point(12, 39);
            textBoxTerm_KEV.Multiline = true;
            textBoxTerm_KEV.Name = "textBoxTerm_KEV";
            textBoxTerm_KEV.ReadOnly = true;
            textBoxTerm_KEV.Size = new Size(644, 53);
            textBoxTerm_KEV.TabIndex = 1;
            textBoxTerm_KEV.Text = "Прочитать данные из файла. Вывести все значения, которые не равны нулю и построить диаграму по этим значениям ";
            // 
            // textBoxCondition_KEV
            // 
            textBoxCondition_KEV.Location = new Point(12, 6);
            textBoxCondition_KEV.Name = "textBoxCondition_KEV";
            textBoxCondition_KEV.ReadOnly = true;
            textBoxCondition_KEV.Size = new Size(125, 27);
            textBoxCondition_KEV.TabIndex = 0;
            textBoxCondition_KEV.Text = "Условие";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewNums_KEV);
            panel1.Controls.Add(textBoxInput_KEV);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 400);
            panel1.TabIndex = 1;
            // 
            // dataGridViewNums_KEV
            // 
            dataGridViewNums_KEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KEV.Location = new Point(18, 36);
            dataGridViewNums_KEV.Name = "dataGridViewNums_KEV";
            dataGridViewNums_KEV.RowHeadersWidth = 51;
            dataGridViewNums_KEV.Size = new Size(158, 292);
            dataGridViewNums_KEV.TabIndex = 1;
            // 
            // textBoxInput_KEV
            // 
            textBoxInput_KEV.Location = new Point(12, 3);
            textBoxInput_KEV.Name = "textBoxInput_KEV";
            textBoxInput_KEV.ReadOnly = true;
            textBoxInput_KEV.Size = new Size(125, 27);
            textBoxInput_KEV.TabIndex = 0;
            textBoxInput_KEV.Text = "Вывод данных";
            // 
            // chartDiag_KEV
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_KEV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_KEV.Legends.Add(legend1);
            chartDiag_KEV.Location = new Point(209, 112);
            chartDiag_KEV.Name = "chartDiag_KEV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            chartDiag_KEV.Series.Add(series1);
            chartDiag_KEV.Size = new Size(955, 381);
            chartDiag_KEV.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 504);
            Controls.Add(chartDiag_KEV);
            Controls.Add(panel1);
            Controls.Add(panelOne_KEV);
            MinimumSize = new Size(1202, 551);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 10 | Киричок Е. В.";
            panelOne_KEV.ResumeLayout(false);
            panelOne_KEV.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KEV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KEV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOne_KEV;
        private TextBox textBoxTerm_KEV;
        private TextBox textBoxCondition_KEV;
        private Button buttonSave_KEV;
        private Button buttonDone_KEV;
        private Button buttonPerform_KEV;
        private Panel panel1;
        private TextBox textBoxInput_KEV;
        private DataGridView dataGridViewNums_KEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KEV;
    }
}
