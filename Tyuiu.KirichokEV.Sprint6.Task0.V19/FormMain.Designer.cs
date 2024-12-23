namespace Tyuiu.KirichokEV.Sprint6.Task0.V19
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
            buttonDone_KEV = new Button();
            groupBoxCondition_KEV = new GroupBox();
            textBox1 = new TextBox();
            pictureBoxFoto_KEV = new PictureBox();
            groupBoxInput_KEV = new GroupBox();
            textBoxVarX_KEV = new TextBox();
            textBoxInput_KEV = new TextBox();
            groupBoxConclusion_KEV = new GroupBox();
            textBoxResult_KEV = new TextBox();
            textBoxConclusion_KEV = new TextBox();
            buttonQuestion_KEV = new Button();
            groupBoxCondition_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto_KEV).BeginInit();
            groupBoxInput_KEV.SuspendLayout();
            groupBoxConclusion_KEV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_KEV
            // 
            buttonDone_KEV.Location = new Point(654, 303);
            buttonDone_KEV.Name = "buttonDone_KEV";
            buttonDone_KEV.Size = new Size(118, 60);
            buttonDone_KEV.TabIndex = 0;
            buttonDone_KEV.Text = "Выполнить ";
            buttonDone_KEV.UseVisualStyleBackColor = true;
            buttonDone_KEV.Click += buttonDone_KEV_Click;
            // 
            // groupBoxCondition_KEV
            // 
            groupBoxCondition_KEV.Controls.Add(textBox1);
            groupBoxCondition_KEV.Location = new Point(15, 15);
            groupBoxCondition_KEV.Name = "groupBoxCondition_KEV";
            groupBoxCondition_KEV.Size = new Size(539, 208);
            groupBoxCondition_KEV.TabIndex = 1;
            groupBoxCondition_KEV.TabStop = false;
            groupBoxCondition_KEV.Text = "Условие ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(527, 165);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вычислить выражение по формуле ";
            // 
            // pictureBoxFoto_KEV
            // 
            pictureBoxFoto_KEV.Image = Properties.Resources.формула1;
            pictureBoxFoto_KEV.Location = new Point(566, 39);
            pictureBoxFoto_KEV.Name = "pictureBoxFoto_KEV";
            pictureBoxFoto_KEV.Size = new Size(206, 62);
            pictureBoxFoto_KEV.TabIndex = 2;
            pictureBoxFoto_KEV.TabStop = false;
            // 
            // groupBoxInput_KEV
            // 
            groupBoxInput_KEV.Controls.Add(textBoxVarX_KEV);
            groupBoxInput_KEV.Controls.Add(textBoxInput_KEV);
            groupBoxInput_KEV.Location = new Point(20, 238);
            groupBoxInput_KEV.Name = "groupBoxInput_KEV";
            groupBoxInput_KEV.Size = new Size(250, 125);
            groupBoxInput_KEV.TabIndex = 3;
            groupBoxInput_KEV.TabStop = false;
            groupBoxInput_KEV.Text = "Ввод данных ";
            // 
            // textBoxVarX_KEV
            // 
            textBoxVarX_KEV.Location = new Point(55, 74);
            textBoxVarX_KEV.Name = "textBoxVarX_KEV";
            textBoxVarX_KEV.Size = new Size(125, 27);
            textBoxVarX_KEV.TabIndex = 1;
            textBoxVarX_KEV.KeyPress += textBoxVarX_KEV_KeyPress;
            // 
            // textBoxInput_KEV
            // 
            textBoxInput_KEV.Location = new Point(55, 40);
            textBoxInput_KEV.Name = "textBoxInput_KEV";
            textBoxInput_KEV.Size = new Size(125, 27);
            textBoxInput_KEV.TabIndex = 0;
            textBoxInput_KEV.Text = "  Переменная Х";
            // 
            // groupBoxConclusion_KEV
            // 
            groupBoxConclusion_KEV.Controls.Add(textBoxResult_KEV);
            groupBoxConclusion_KEV.Controls.Add(textBoxConclusion_KEV);
            groupBoxConclusion_KEV.Location = new Point(285, 238);
            groupBoxConclusion_KEV.Name = "groupBoxConclusion_KEV";
            groupBoxConclusion_KEV.Size = new Size(250, 125);
            groupBoxConclusion_KEV.TabIndex = 4;
            groupBoxConclusion_KEV.TabStop = false;
            groupBoxConclusion_KEV.Text = "groupBox1";
            // 
            // textBoxResult_KEV
            // 
            textBoxResult_KEV.Location = new Point(62, 75);
            textBoxResult_KEV.Name = "textBoxResult_KEV";
            textBoxResult_KEV.ReadOnly = true;
            textBoxResult_KEV.Size = new Size(125, 27);
            textBoxResult_KEV.TabIndex = 1;
            // 
            // textBoxConclusion_KEV
            // 
            textBoxConclusion_KEV.Location = new Point(64, 40);
            textBoxConclusion_KEV.Name = "textBoxConclusion_KEV";
            textBoxConclusion_KEV.Size = new Size(125, 27);
            textBoxConclusion_KEV.TabIndex = 0;
            textBoxConclusion_KEV.Text = "      Результат ";
            // 
            // buttonQuestion_KEV
            // 
            buttonQuestion_KEV.Location = new Point(566, 303);
            buttonQuestion_KEV.Name = "buttonQuestion_KEV";
            buttonQuestion_KEV.Size = new Size(69, 60);
            buttonQuestion_KEV.TabIndex = 5;
            buttonQuestion_KEV.Text = "?";
            buttonQuestion_KEV.UseVisualStyleBackColor = true;
            buttonQuestion_KEV.Click += buttonQuestion_KEV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(buttonQuestion_KEV);
            Controls.Add(groupBoxConclusion_KEV);
            Controls.Add(groupBoxInput_KEV);
            Controls.Add(pictureBoxFoto_KEV);
            Controls.Add(groupBoxCondition_KEV);
            Controls.Add(buttonDone_KEV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 19 | Киричок Е. В.";
            groupBoxCondition_KEV.ResumeLayout(false);
            groupBoxCondition_KEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto_KEV).EndInit();
            groupBoxInput_KEV.ResumeLayout(false);
            groupBoxInput_KEV.PerformLayout();
            groupBoxConclusion_KEV.ResumeLayout(false);
            groupBoxConclusion_KEV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_KEV;
        private GroupBox groupBoxCondition_KEV;
        private TextBox textBox1;
        private PictureBox pictureBoxFoto_KEV;
        private GroupBox groupBoxInput_KEV;
        private TextBox textBoxVarX_KEV;
        private TextBox textBoxInput_KEV;
        private GroupBox groupBoxConclusion_KEV;
        private TextBox textBoxConclusion_KEV;
        private TextBox textBoxResult_KEV;
        private Button buttonQuestion_KEV;
    }
}
