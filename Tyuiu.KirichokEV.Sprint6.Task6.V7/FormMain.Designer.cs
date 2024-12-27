namespace Tyuiu.KirichokEV.Sprint6.Task6.V7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelOne_KEV = new Panel();
            buttonDone_KEV = new Button();
            buttonPerform_KEV = new Button();
            buttonOpen_KEV = new Button();
            textBoxCondition_KEV = new TextBox();
            panelTwo_KEV = new Panel();
            textBoxTextInput_KEV = new TextBox();
            textBoxInput_KEV = new TextBox();
            panel1 = new Panel();
            textBoxResult_KEV = new TextBox();
            textBoxConclusion_KEV = new TextBox();
            openFileDialogTask_KEV = new OpenFileDialog();
            toolTipTppp_KEV = new ToolTip(components);
            panelOne_KEV.SuspendLayout();
            panelTwo_KEV.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelOne_KEV
            // 
            panelOne_KEV.Controls.Add(buttonDone_KEV);
            panelOne_KEV.Controls.Add(buttonPerform_KEV);
            panelOne_KEV.Controls.Add(buttonOpen_KEV);
            panelOne_KEV.Dock = DockStyle.Top;
            panelOne_KEV.Location = new Point(0, 0);
            panelOne_KEV.Name = "panelOne_KEV";
            panelOne_KEV.Size = new Size(1338, 156);
            panelOne_KEV.TabIndex = 0;
            // 
            // buttonDone_KEV
            // 
            buttonDone_KEV.Location = new Point(1214, 12);
            buttonDone_KEV.Name = "buttonDone_KEV";
            buttonDone_KEV.Size = new Size(112, 64);
            buttonDone_KEV.TabIndex = 2;
            buttonDone_KEV.Text = "Справка";
            toolTipTppp_KEV.SetToolTip(buttonDone_KEV, "Сведения о программе ");
            buttonDone_KEV.UseVisualStyleBackColor = true;
            buttonDone_KEV.Click += buttonDone_KEV_Click;
            // 
            // buttonPerform_KEV
            // 
            buttonPerform_KEV.Location = new Point(139, 12);
            buttonPerform_KEV.Name = "buttonPerform_KEV";
            buttonPerform_KEV.Size = new Size(112, 64);
            buttonPerform_KEV.TabIndex = 1;
            buttonPerform_KEV.Text = "Выполнить ";
            toolTipTppp_KEV.SetToolTip(buttonPerform_KEV, "Выводит каждый третий элемент строки \r\n");
            buttonPerform_KEV.UseVisualStyleBackColor = true;
            buttonPerform_KEV.Click += buttonPerform_KEV_Click;
            // 
            // buttonOpen_KEV
            // 
            buttonOpen_KEV.Location = new Point(12, 12);
            buttonOpen_KEV.Name = "buttonOpen_KEV";
            buttonOpen_KEV.Size = new Size(112, 64);
            buttonOpen_KEV.TabIndex = 0;
            buttonOpen_KEV.Text = "Открыть ";
            toolTipTppp_KEV.SetToolTip(buttonOpen_KEV, "Открыть файл\r\nВыберите нужный файл для обработки \r\n");
            buttonOpen_KEV.UseVisualStyleBackColor = true;
            buttonOpen_KEV.Click += buttonOpen_KEV_Click;
            // 
            // textBoxCondition_KEV
            // 
            textBoxCondition_KEV.Location = new Point(13, 88);
            textBoxCondition_KEV.Multiline = true;
            textBoxCondition_KEV.Name = "textBoxCondition_KEV";
            textBoxCondition_KEV.ReadOnly = true;
            textBoxCondition_KEV.Size = new Size(1313, 68);
            textBoxCondition_KEV.TabIndex = 1;
            textBoxCondition_KEV.Text = resources.GetString("textBoxCondition_KEV.Text");
            // 
            // panelTwo_KEV
            // 
            panelTwo_KEV.Controls.Add(textBoxTextInput_KEV);
            panelTwo_KEV.Controls.Add(textBoxInput_KEV);
            panelTwo_KEV.Location = new Point(0, 157);
            panelTwo_KEV.Name = "panelTwo_KEV";
            panelTwo_KEV.Size = new Size(631, 293);
            panelTwo_KEV.TabIndex = 2;
            // 
            // textBoxTextInput_KEV
            // 
            textBoxTextInput_KEV.Location = new Point(12, 38);
            textBoxTextInput_KEV.Multiline = true;
            textBoxTextInput_KEV.Name = "textBoxTextInput_KEV";
            textBoxTextInput_KEV.ReadOnly = true;
            textBoxTextInput_KEV.Size = new Size(616, 243);
            textBoxTextInput_KEV.TabIndex = 1;
            // 
            // textBoxInput_KEV
            // 
            textBoxInput_KEV.Location = new Point(13, 5);
            textBoxInput_KEV.Name = "textBoxInput_KEV";
            textBoxInput_KEV.ReadOnly = true;
            textBoxInput_KEV.Size = new Size(125, 27);
            textBoxInput_KEV.TabIndex = 0;
            textBoxInput_KEV.Text = "Ввод:";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxResult_KEV);
            panel1.Controls.Add(textBoxConclusion_KEV);
            panel1.Location = new Point(634, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 293);
            panel1.TabIndex = 3;
            // 
            // textBoxResult_KEV
            // 
            textBoxResult_KEV.Location = new Point(12, 38);
            textBoxResult_KEV.Multiline = true;
            textBoxResult_KEV.Name = "textBoxResult_KEV";
            textBoxResult_KEV.ReadOnly = true;
            textBoxResult_KEV.Size = new Size(616, 243);
            textBoxResult_KEV.TabIndex = 1;
            // 
            // textBoxConclusion_KEV
            // 
            textBoxConclusion_KEV.Location = new Point(13, 5);
            textBoxConclusion_KEV.Name = "textBoxConclusion_KEV";
            textBoxConclusion_KEV.ReadOnly = true;
            textBoxConclusion_KEV.Size = new Size(125, 27);
            textBoxConclusion_KEV.TabIndex = 0;
            textBoxConclusion_KEV.Text = "Вывод:";
            // 
            // openFileDialogTask_KEV
            // 
            openFileDialogTask_KEV.FileName = "openFileDialogTask_KEV";
            // 
            // toolTipTppp_KEV
            // 
            toolTipTppp_KEV.ToolTipIcon = ToolTipIcon.Info;
            toolTipTppp_KEV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 450);
            Controls.Add(panel1);
            Controls.Add(panelTwo_KEV);
            Controls.Add(textBoxCondition_KEV);
            Controls.Add(panelOne_KEV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 7 | Кирчиок Е. В.";
            panelOne_KEV.ResumeLayout(false);
            panelTwo_KEV.ResumeLayout(false);
            panelTwo_KEV.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelOne_KEV;
        private Button buttonDone_KEV;
        private Button buttonPerform_KEV;
        private Button buttonOpen_KEV;
        private TextBox textBoxCondition_KEV;
        private Panel panelTwo_KEV;
        private TextBox textBoxTextInput_KEV;
        private TextBox textBoxInput_KEV;
        private Panel panel1;
        private TextBox textBoxResult_KEV;
        private TextBox textBoxConclusion_KEV;
        private OpenFileDialog openFileDialogTask_KEV;
        private ToolTip toolTipTppp_KEV;
    }
}
