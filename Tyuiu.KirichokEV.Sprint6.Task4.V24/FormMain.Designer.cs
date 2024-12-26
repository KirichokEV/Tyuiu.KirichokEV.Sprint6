namespace Tyuiu.KirichokEV.Sprint6.Task4.V24
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxCondition_KEV = new GroupBox();
            textBoxCondition_KEV = new TextBox();
            groupBoxInput_KEV = new GroupBox();
            buttonDone_KEV = new Button();
            buttonSave_KEV = new Button();
            buttonPerform_KEV = new Button();
            textBoxStop_KEV = new TextBox();
            textBoxStart_KEV = new TextBox();
            textBoxStops_KEV = new TextBox();
            textBoxStarts_KEV = new TextBox();
            textBoxConclusion_KEV = new TextBox();
            textBoxResult_KEV = new TextBox();
            chartFunction_KEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_KEV.SuspendLayout();
            groupBoxInput_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KEV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KEV
            // 
            groupBoxCondition_KEV.Controls.Add(textBoxCondition_KEV);
            groupBoxCondition_KEV.Location = new Point(0, 0);
            groupBoxCondition_KEV.Name = "groupBoxCondition_KEV";
            groupBoxCondition_KEV.Size = new Size(1313, 522);
            groupBoxCondition_KEV.TabIndex = 0;
            groupBoxCondition_KEV.TabStop = false;
            groupBoxCondition_KEV.Text = "Условие";
            // 
            // textBoxCondition_KEV
            // 
            textBoxCondition_KEV.Location = new Point(8, 23);
            textBoxCondition_KEV.Multiline = true;
            textBoxCondition_KEV.Name = "textBoxCondition_KEV";
            textBoxCondition_KEV.ReadOnly = true;
            textBoxCondition_KEV.Size = new Size(593, 65);
            textBoxCondition_KEV.TabIndex = 0;
            textBoxCondition_KEV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в textBox, построить график функции и сохарнить в файл по нажатию кнопки ";
            // 
            // groupBoxInput_KEV
            // 
            groupBoxInput_KEV.Controls.Add(buttonDone_KEV);
            groupBoxInput_KEV.Controls.Add(buttonSave_KEV);
            groupBoxInput_KEV.Controls.Add(buttonPerform_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxStop_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxStart_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxStops_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxStarts_KEV);
            groupBoxInput_KEV.Location = new Point(637, 0);
            groupBoxInput_KEV.Name = "groupBoxInput_KEV";
            groupBoxInput_KEV.Size = new Size(676, 522);
            groupBoxInput_KEV.TabIndex = 1;
            groupBoxInput_KEV.TabStop = false;
            groupBoxInput_KEV.Text = "Ввод данных";
            // 
            // buttonDone_KEV
            // 
            buttonDone_KEV.BackColor = Color.DarkBlue;
            buttonDone_KEV.ForeColor = SystemColors.ButtonHighlight;
            buttonDone_KEV.Location = new Point(564, 22);
            buttonDone_KEV.Name = "buttonDone_KEV";
            buttonDone_KEV.Size = new Size(106, 62);
            buttonDone_KEV.TabIndex = 6;
            buttonDone_KEV.Text = "Справка ";
            buttonDone_KEV.UseVisualStyleBackColor = false;
            buttonDone_KEV.Click += buttonDone_KEV_Click;
            // 
            // buttonSave_KEV
            // 
            buttonSave_KEV.BackColor = Color.MediumBlue;
            buttonSave_KEV.ForeColor = SystemColors.Control;
            buttonSave_KEV.Location = new Point(441, 22);
            buttonSave_KEV.Name = "buttonSave_KEV";
            buttonSave_KEV.Size = new Size(107, 66);
            buttonSave_KEV.TabIndex = 5;
            buttonSave_KEV.Text = "Сохранить ";
            buttonSave_KEV.UseVisualStyleBackColor = false;
            buttonSave_KEV.Click += buttonSave_KEV_Click;
            // 
            // buttonPerform_KEV
            // 
            buttonPerform_KEV.BackColor = Color.Blue;
            buttonPerform_KEV.ForeColor = SystemColors.ButtonFace;
            buttonPerform_KEV.Location = new Point(320, 22);
            buttonPerform_KEV.Name = "buttonPerform_KEV";
            buttonPerform_KEV.Size = new Size(104, 65);
            buttonPerform_KEV.TabIndex = 4;
            buttonPerform_KEV.Text = "Выполнить ";
            buttonPerform_KEV.UseVisualStyleBackColor = false;
            buttonPerform_KEV.Click += buttonPerform_KEV_Click;
            // 
            // textBoxStop_KEV
            // 
            textBoxStop_KEV.Location = new Point(165, 61);
            textBoxStop_KEV.Name = "textBoxStop_KEV";
            textBoxStop_KEV.Size = new Size(125, 27);
            textBoxStop_KEV.TabIndex = 3;
            // 
            // textBoxStart_KEV
            // 
            textBoxStart_KEV.Location = new Point(6, 61);
            textBoxStart_KEV.Name = "textBoxStart_KEV";
            textBoxStart_KEV.Size = new Size(125, 27);
            textBoxStart_KEV.TabIndex = 2;
            // 
            // textBoxStops_KEV
            // 
            textBoxStops_KEV.Location = new Point(165, 26);
            textBoxStops_KEV.Name = "textBoxStops_KEV";
            textBoxStops_KEV.ReadOnly = true;
            textBoxStops_KEV.Size = new Size(125, 27);
            textBoxStops_KEV.TabIndex = 1;
            textBoxStops_KEV.Text = "Конец шага:";
            // 
            // textBoxStarts_KEV
            // 
            textBoxStarts_KEV.Location = new Point(6, 26);
            textBoxStarts_KEV.Name = "textBoxStarts_KEV";
            textBoxStarts_KEV.ReadOnly = true;
            textBoxStarts_KEV.Size = new Size(125, 27);
            textBoxStarts_KEV.TabIndex = 0;
            textBoxStarts_KEV.Text = "Старт шага:";
            // 
            // textBoxConclusion_KEV
            // 
            textBoxConclusion_KEV.Location = new Point(12, 119);
            textBoxConclusion_KEV.Name = "textBoxConclusion_KEV";
            textBoxConclusion_KEV.ReadOnly = true;
            textBoxConclusion_KEV.Size = new Size(57, 27);
            textBoxConclusion_KEV.TabIndex = 2;
            textBoxConclusion_KEV.Text = "Вывод";
            // 
            // textBoxResult_KEV
            // 
            textBoxResult_KEV.Location = new Point(12, 152);
            textBoxResult_KEV.Multiline = true;
            textBoxResult_KEV.Name = "textBoxResult_KEV";
            textBoxResult_KEV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KEV.Size = new Size(253, 366);
            textBoxResult_KEV.TabIndex = 3;
            // 
            // chartFunction_KEV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KEV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KEV.Legends.Add(legend1);
            chartFunction_KEV.Location = new Point(317, 146);
            chartFunction_KEV.Name = "chartFunction_KEV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KEV.Series.Add(series1);
            chartFunction_KEV.Size = new Size(962, 375);
            chartFunction_KEV.TabIndex = 4;
            chartFunction_KEV.Text = "chart1";
            title1.ForeColor = Color.MediumBlue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_KEV.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 522);
            Controls.Add(chartFunction_KEV);
            Controls.Add(textBoxResult_KEV);
            Controls.Add(textBoxConclusion_KEV);
            Controls.Add(groupBoxInput_KEV);
            Controls.Add(groupBoxCondition_KEV);
            MinimumSize = new Size(1331, 569);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 24 | Киричок Е. В.";
            groupBoxCondition_KEV.ResumeLayout(false);
            groupBoxCondition_KEV.PerformLayout();
            groupBoxInput_KEV.ResumeLayout(false);
            groupBoxInput_KEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCondition_KEV;
        private TextBox textBoxCondition_KEV;
        private GroupBox groupBoxInput_KEV;
        private TextBox textBoxStart_KEV;
        private TextBox textBoxStops_KEV;
        private TextBox textBoxStarts_KEV;
        private TextBox textBoxStop_KEV;
        private Button buttonDone_KEV;
        private Button buttonSave_KEV;
        private Button buttonPerform_KEV;
        private TextBox textBoxConclusion_KEV;
        private TextBox textBoxResult_KEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KEV;
    }
}
