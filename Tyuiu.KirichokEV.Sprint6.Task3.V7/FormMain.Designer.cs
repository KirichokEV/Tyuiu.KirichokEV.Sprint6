namespace Tyuiu.KirichokEV.Sprint6.Task3.V7
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
            groupBoxCondition_KEV = new GroupBox();
            dataGridViewMatrix_KEV = new DataGridView();
            textBoxCondition_KEV = new TextBox();
            groupBoxInput_KEV = new GroupBox();
            dataGridViewMtrx_KEV = new DataGridView();
            buttonDone_KEV = new Button();
            buttonPerform_KEV = new Button();
            groupBoxCondition_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KEV).BeginInit();
            groupBoxInput_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_KEV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KEV
            // 
            groupBoxCondition_KEV.Controls.Add(dataGridViewMatrix_KEV);
            groupBoxCondition_KEV.Controls.Add(textBoxCondition_KEV);
            groupBoxCondition_KEV.Location = new Point(13, 14);
            groupBoxCondition_KEV.Name = "groupBoxCondition_KEV";
            groupBoxCondition_KEV.Size = new Size(430, 431);
            groupBoxCondition_KEV.TabIndex = 0;
            groupBoxCondition_KEV.TabStop = false;
            groupBoxCondition_KEV.Text = "Условие";
            // 
            // dataGridViewMatrix_KEV
            // 
            dataGridViewMatrix_KEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KEV.ColumnHeadersVisible = false;
            dataGridViewMatrix_KEV.Location = new Point(5, 84);
            dataGridViewMatrix_KEV.Name = "dataGridViewMatrix_KEV";
            dataGridViewMatrix_KEV.RowHeadersWidth = 51;
            dataGridViewMatrix_KEV.Size = new Size(372, 334);
            dataGridViewMatrix_KEV.TabIndex = 1;
            // 
            // textBoxCondition_KEV
            // 
            textBoxCondition_KEV.Location = new Point(6, 26);
            textBoxCondition_KEV.Multiline = true;
            textBoxCondition_KEV.Name = "textBoxCondition_KEV";
            textBoxCondition_KEV.ReadOnly = true;
            textBoxCondition_KEV.Size = new Size(322, 49);
            textBoxCondition_KEV.TabIndex = 0;
            textBoxCondition_KEV.Text = "Дана матрица 5 на 5.\r\nРасположить 4 столбец по возрастанию.\r\n";
            // 
            // groupBoxInput_KEV
            // 
            groupBoxInput_KEV.Controls.Add(dataGridViewMtrx_KEV);
            groupBoxInput_KEV.Controls.Add(buttonDone_KEV);
            groupBoxInput_KEV.Controls.Add(buttonPerform_KEV);
            groupBoxInput_KEV.Location = new Point(466, 14);
            groupBoxInput_KEV.Name = "groupBoxInput_KEV";
            groupBoxInput_KEV.Size = new Size(299, 424);
            groupBoxInput_KEV.TabIndex = 1;
            groupBoxInput_KEV.TabStop = false;
            groupBoxInput_KEV.Text = "Вывод данных";
            // 
            // dataGridViewMtrx_KEV
            // 
            dataGridViewMtrx_KEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx_KEV.Location = new Point(6, 26);
            dataGridViewMtrx_KEV.Name = "dataGridViewMtrx_KEV";
            dataGridViewMtrx_KEV.RowHeadersWidth = 51;
            dataGridViewMtrx_KEV.Size = new Size(300, 318);
            dataGridViewMtrx_KEV.TabIndex = 2;
            // 
            // buttonDone_KEV
            // 
            buttonDone_KEV.BackColor = Color.Indigo;
            buttonDone_KEV.ForeColor = SystemColors.ButtonFace;
            buttonDone_KEV.Location = new Point(24, 350);
            buttonDone_KEV.Name = "buttonDone_KEV";
            buttonDone_KEV.Size = new Size(94, 68);
            buttonDone_KEV.TabIndex = 1;
            buttonDone_KEV.Text = "?";
            buttonDone_KEV.UseVisualStyleBackColor = false;
            buttonDone_KEV.Click += buttonDone_KEV_Click;
            // 
            // buttonPerform_KEV
            // 
            buttonPerform_KEV.BackColor = Color.SlateBlue;
            buttonPerform_KEV.ForeColor = SystemColors.ButtonFace;
            buttonPerform_KEV.Location = new Point(137, 350);
            buttonPerform_KEV.Name = "buttonPerform_KEV";
            buttonPerform_KEV.Size = new Size(156, 68);
            buttonPerform_KEV.TabIndex = 0;
            buttonPerform_KEV.Text = "Выполнить ";
            buttonPerform_KEV.UseVisualStyleBackColor = false;
            buttonPerform_KEV.Click += buttonPerform_KEV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInput_KEV);
            Controls.Add(groupBoxCondition_KEV);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxCondition_KEV.ResumeLayout(false);
            groupBoxCondition_KEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KEV).EndInit();
            groupBoxInput_KEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_KEV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KEV;
        private TextBox textBoxCondition_KEV;
        private DataGridView dataGridViewMatrix_KEV;
        private GroupBox groupBoxInput_KEV;
        private Button buttonDone_KEV;
        private Button buttonPerform_KEV;
        private DataGridView dataGridViewMtrx_KEV;
    }
}
