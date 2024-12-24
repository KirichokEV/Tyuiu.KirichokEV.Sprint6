namespace Tyuiu.KirichokEV.Sprint6.Task2.V2
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
            buttonPerform_KEV = new Button();
            groupBoxCondition_KEV = new GroupBox();
            textBoxCondition_KEV = new TextBox();
            groupBoxInput_KEV = new GroupBox();
            textBoxStop_KEV = new TextBox();
            textBoxStart_KEV = new TextBox();
            textBoxStops_KEV = new TextBox();
            textBoxStars_KEV = new TextBox();
            dataGridViewFunction_KEV = new DataGridView();
            ColumnOne_KEV = new DataGridViewTextBoxColumn();
            ColumnTwo_KEV = new DataGridViewTextBoxColumn();
            groupBoxConclusion_KEV = new GroupBox();
            chartFunction_KEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxConclusion_KEV = new TextBox();
            buttonDone_KEV = new Button();
            groupBoxCondition_KEV.SuspendLayout();
            groupBoxInput_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KEV).BeginInit();
            groupBoxConclusion_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KEV).BeginInit();
            SuspendLayout();
            // 
            // buttonPerform_KEV
            // 
            buttonPerform_KEV.BackColor = Color.RoyalBlue;
            buttonPerform_KEV.ForeColor = SystemColors.ControlLight;
            buttonPerform_KEV.Location = new Point(515, 376);
            buttonPerform_KEV.Name = "buttonPerform_KEV";
            buttonPerform_KEV.Size = new Size(115, 62);
            buttonPerform_KEV.TabIndex = 0;
            buttonPerform_KEV.Text = "Выполнить ";
            buttonPerform_KEV.UseVisualStyleBackColor = false;
            buttonPerform_KEV.Click += buttonPerform_KEV_Click;
            buttonPerform_KEV.MouseDown += buttonPerform_KEV_MouseDown;
            buttonPerform_KEV.MouseEnter += buttonPerform_KEV_MouseEnter;
            buttonPerform_KEV.MouseLeave += buttonPerform_KEV_MouseLeave;
            // 
            // groupBoxCondition_KEV
            // 
            groupBoxCondition_KEV.Controls.Add(textBoxCondition_KEV);
            groupBoxCondition_KEV.Location = new Point(15, 12);
            groupBoxCondition_KEV.Name = "groupBoxCondition_KEV";
            groupBoxCondition_KEV.Size = new Size(621, 305);
            groupBoxCondition_KEV.TabIndex = 1;
            groupBoxCondition_KEV.TabStop = false;
            groupBoxCondition_KEV.Text = "Условие";
            // 
            // textBoxCondition_KEV
            // 
            textBoxCondition_KEV.Location = new Point(7, 27);
            textBoxCondition_KEV.Multiline = true;
            textBoxCondition_KEV.Name = "textBoxCondition_KEV";
            textBoxCondition_KEV.ReadOnly = true;
            textBoxCondition_KEV.Size = new Size(608, 272);
            textBoxCondition_KEV.TabIndex = 0;
            textBoxCondition_KEV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGidView и построить график функции. ";
            // 
            // groupBoxInput_KEV
            // 
            groupBoxInput_KEV.Controls.Add(textBoxStop_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxStart_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxStops_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxStars_KEV);
            groupBoxInput_KEV.Location = new Point(15, 323);
            groupBoxInput_KEV.Name = "groupBoxInput_KEV";
            groupBoxInput_KEV.Size = new Size(340, 125);
            groupBoxInput_KEV.TabIndex = 2;
            groupBoxInput_KEV.TabStop = false;
            groupBoxInput_KEV.Text = "Ввод данных";
            // 
            // textBoxStop_KEV
            // 
            textBoxStop_KEV.Location = new Point(176, 71);
            textBoxStop_KEV.Name = "textBoxStop_KEV";
            textBoxStop_KEV.Size = new Size(125, 27);
            textBoxStop_KEV.TabIndex = 3;
            // 
            // textBoxStart_KEV
            // 
            textBoxStart_KEV.Location = new Point(7, 71);
            textBoxStart_KEV.Name = "textBoxStart_KEV";
            textBoxStart_KEV.Size = new Size(125, 27);
            textBoxStart_KEV.TabIndex = 2;
            // 
            // textBoxStops_KEV
            // 
            textBoxStops_KEV.Location = new Point(176, 26);
            textBoxStops_KEV.Name = "textBoxStops_KEV";
            textBoxStops_KEV.ReadOnly = true;
            textBoxStops_KEV.Size = new Size(125, 27);
            textBoxStops_KEV.TabIndex = 1;
            textBoxStops_KEV.Text = "Конец шага:";
            // 
            // textBoxStars_KEV
            // 
            textBoxStars_KEV.Location = new Point(6, 26);
            textBoxStars_KEV.Name = "textBoxStars_KEV";
            textBoxStars_KEV.ReadOnly = true;
            textBoxStars_KEV.Size = new Size(125, 27);
            textBoxStars_KEV.TabIndex = 0;
            textBoxStars_KEV.Text = "Старт шага:";
            // 
            // dataGridViewFunction_KEV
            // 
            dataGridViewFunction_KEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KEV.Columns.AddRange(new DataGridViewColumn[] { ColumnOne_KEV, ColumnTwo_KEV });
            dataGridViewFunction_KEV.Location = new Point(18, 55);
            dataGridViewFunction_KEV.Name = "dataGridViewFunction_KEV";
            dataGridViewFunction_KEV.RowHeadersVisible = false;
            dataGridViewFunction_KEV.RowHeadersWidth = 51;
            dataGridViewFunction_KEV.Size = new Size(154, 362);
            dataGridViewFunction_KEV.TabIndex = 3;
            // 
            // ColumnOne_KEV
            // 
            ColumnOne_KEV.HeaderText = "X";
            ColumnOne_KEV.MinimumWidth = 6;
            ColumnOne_KEV.Name = "ColumnOne_KEV";
            ColumnOne_KEV.Width = 50;
            // 
            // ColumnTwo_KEV
            // 
            ColumnTwo_KEV.HeaderText = "F(x)";
            ColumnTwo_KEV.MinimumWidth = 6;
            ColumnTwo_KEV.Name = "ColumnTwo_KEV";
            ColumnTwo_KEV.Width = 50;
            // 
            // groupBoxConclusion_KEV
            // 
            groupBoxConclusion_KEV.Controls.Add(chartFunction_KEV);
            groupBoxConclusion_KEV.Controls.Add(textBoxConclusion_KEV);
            groupBoxConclusion_KEV.Controls.Add(dataGridViewFunction_KEV);
            groupBoxConclusion_KEV.Location = new Point(663, 21);
            groupBoxConclusion_KEV.Name = "groupBoxConclusion_KEV";
            groupBoxConclusion_KEV.Size = new Size(582, 427);
            groupBoxConclusion_KEV.TabIndex = 4;
            groupBoxConclusion_KEV.TabStop = false;
            groupBoxConclusion_KEV.Text = "Вывод данных";
            // 
            // chartFunction_KEV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KEV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KEV.Legends.Add(legend1);
            chartFunction_KEV.Location = new Point(195, 37);
            chartFunction_KEV.Name = "chartFunction_KEV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "SeriesFunction";
            chartFunction_KEV.Series.Add(series1);
            chartFunction_KEV.Size = new Size(563, 375);
            chartFunction_KEV.TabIndex = 5;
            // 
            // textBoxConclusion_KEV
            // 
            textBoxConclusion_KEV.Location = new Point(15, 22);
            textBoxConclusion_KEV.Name = "textBoxConclusion_KEV";
            textBoxConclusion_KEV.ReadOnly = true;
            textBoxConclusion_KEV.Size = new Size(125, 27);
            textBoxConclusion_KEV.TabIndex = 4;
            textBoxConclusion_KEV.Text = "Результат:";
            // 
            // buttonDone_KEV
            // 
            buttonDone_KEV.BackColor = Color.MidnightBlue;
            buttonDone_KEV.ForeColor = SystemColors.ControlLight;
            buttonDone_KEV.Location = new Point(382, 376);
            buttonDone_KEV.Name = "buttonDone_KEV";
            buttonDone_KEV.Size = new Size(114, 62);
            buttonDone_KEV.TabIndex = 5;
            buttonDone_KEV.Text = "?";
            buttonDone_KEV.UseVisualStyleBackColor = false;
            buttonDone_KEV.Click += buttonDone_KEV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 450);
            Controls.Add(buttonDone_KEV);
            Controls.Add(groupBoxConclusion_KEV);
            Controls.Add(groupBoxInput_KEV);
            Controls.Add(groupBoxCondition_KEV);
            Controls.Add(buttonPerform_KEV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Варинт 2 |Киричок Е. В.";
            groupBoxCondition_KEV.ResumeLayout(false);
            groupBoxCondition_KEV.PerformLayout();
            groupBoxInput_KEV.ResumeLayout(false);
            groupBoxInput_KEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KEV).EndInit();
            groupBoxConclusion_KEV.ResumeLayout(false);
            groupBoxConclusion_KEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KEV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPerform_KEV;
        private GroupBox groupBoxCondition_KEV;
        private TextBox textBoxCondition_KEV;
        private GroupBox groupBoxInput_KEV;
        private TextBox textBoxStop_KEV;
        private TextBox textBoxStart_KEV;
        private TextBox textBoxStops_KEV;
        private TextBox textBoxStars_KEV;
        private DataGridView dataGridViewFunction_KEV;
        private GroupBox groupBoxConclusion_KEV;
        private TextBox textBoxConclusion_KEV;
        private DataGridViewTextBoxColumn ColumnOne_KEV;
        private DataGridViewTextBoxColumn ColumnTwo_KEV;
        private Button buttonDone_KEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KEV;
    }
}
