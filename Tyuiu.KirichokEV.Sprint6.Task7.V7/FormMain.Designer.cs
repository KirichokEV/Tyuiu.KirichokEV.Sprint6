namespace Tyuiu.KirichokEV.Sprint6.Task7.V7
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
            buttonSave_KEV = new Button();
            buttonPerform_KEV = new Button();
            buttonOpen_KEV = new Button();
            groupBoxCondition_KEV = new GroupBox();
            textBoxCondition_KEV = new TextBox();
            groupBoxInput_KEV = new GroupBox();
            dataGridViewMatrix_KEV = new DataGridView();
            panelThreee_KEV = new Panel();
            panelTwo_KEV = new Panel();
            panelFhore_KEV = new Panel();
            groupBoxConclusion_KEV = new GroupBox();
            dataGridViewOutMatrix_KEV = new DataGridView();
            openFileDialogTask_KEV = new OpenFileDialog();
            toolTipButton_KEV = new ToolTip(components);
            saveFileDialogMatrix_KEV = new SaveFileDialog();
            panelOne_KEV.SuspendLayout();
            groupBoxCondition_KEV.SuspendLayout();
            groupBoxInput_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KEV).BeginInit();
            panelThreee_KEV.SuspendLayout();
            panelTwo_KEV.SuspendLayout();
            panelFhore_KEV.SuspendLayout();
            groupBoxConclusion_KEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_KEV).BeginInit();
            SuspendLayout();
            // 
            // panelOne_KEV
            // 
            panelOne_KEV.Controls.Add(buttonDone_KEV);
            panelOne_KEV.Controls.Add(buttonSave_KEV);
            panelOne_KEV.Controls.Add(buttonPerform_KEV);
            panelOne_KEV.Controls.Add(buttonOpen_KEV);
            panelOne_KEV.Location = new Point(3, 2);
            panelOne_KEV.Name = "panelOne_KEV";
            panelOne_KEV.Size = new Size(1319, 99);
            panelOne_KEV.TabIndex = 0;
            // 
            // buttonDone_KEV
            // 
            buttonDone_KEV.Location = new Point(1199, 23);
            buttonDone_KEV.Name = "buttonDone_KEV";
            buttonDone_KEV.Size = new Size(94, 56);
            buttonDone_KEV.TabIndex = 3;
            buttonDone_KEV.Text = "Справка ";
            buttonDone_KEV.UseVisualStyleBackColor = true;
            buttonDone_KEV.Click += buttonDone_KEV_Click;
            buttonDone_KEV.MouseEnter += buttomDone_KEV_MouseEnter;
            // 
            // buttonSave_KEV
            // 
            buttonSave_KEV.Location = new Point(252, 23);
            buttonSave_KEV.Name = "buttonSave_KEV";
            buttonSave_KEV.Size = new Size(94, 56);
            buttonSave_KEV.TabIndex = 2;
            buttonSave_KEV.Text = "Сохранить ";
            buttonSave_KEV.UseVisualStyleBackColor = true;
            buttonSave_KEV.Click += buttonSave_KEV_Click;
            buttonSave_KEV.MouseEnter += buttonSave_KEV_MouseEnter;
            // 
            // buttonPerform_KEV
            // 
            buttonPerform_KEV.FlatStyle = FlatStyle.Flat;
            buttonPerform_KEV.Location = new Point(126, 23);
            buttonPerform_KEV.Name = "buttonPerform_KEV";
            buttonPerform_KEV.Size = new Size(110, 56);
            buttonPerform_KEV.TabIndex = 1;
            buttonPerform_KEV.Text = "Выполнить ";
            buttonPerform_KEV.UseVisualStyleBackColor = true;
            buttonPerform_KEV.Click += buttonPerform_KEV_Click;
            buttonPerform_KEV.MouseEnter += buttonPerform_KEV_MouseEnter;
            // 
            // buttonOpen_KEV
            // 
            buttonOpen_KEV.Location = new Point(13, 23);
            buttonOpen_KEV.Name = "buttonOpen_KEV";
            buttonOpen_KEV.Size = new Size(94, 56);
            buttonOpen_KEV.TabIndex = 0;
            buttonOpen_KEV.Text = "Открыть ";
            buttonOpen_KEV.UseVisualStyleBackColor = true;
            buttonOpen_KEV.Click += buttonOpen_KEV_Click;
            buttonOpen_KEV.MouseEnter += duttonOpen_KEV_MouseEnter;
            // 
            // groupBoxCondition_KEV
            // 
            groupBoxCondition_KEV.Controls.Add(textBoxCondition_KEV);
            groupBoxCondition_KEV.Location = new Point(4, 3);
            groupBoxCondition_KEV.Name = "groupBoxCondition_KEV";
            groupBoxCondition_KEV.Size = new Size(1307, 74);
            groupBoxCondition_KEV.TabIndex = 0;
            groupBoxCondition_KEV.TabStop = false;
            groupBoxCondition_KEV.Text = "Условие ";
            // 
            // textBoxCondition_KEV
            // 
            textBoxCondition_KEV.Location = new Point(4, 19);
            textBoxCondition_KEV.Multiline = true;
            textBoxCondition_KEV.Name = "textBoxCondition_KEV";
            textBoxCondition_KEV.ReadOnly = true;
            textBoxCondition_KEV.Size = new Size(1295, 49);
            textBoxCondition_KEV.TabIndex = 0;
            textBoxCondition_KEV.Text = resources.GetString("textBoxCondition_KEV.Text");
            // 
            // groupBoxInput_KEV
            // 
            groupBoxInput_KEV.Controls.Add(dataGridViewMatrix_KEV);
            groupBoxInput_KEV.Location = new Point(3, 3);
            groupBoxInput_KEV.Name = "groupBoxInput_KEV";
            groupBoxInput_KEV.Size = new Size(483, 234);
            groupBoxInput_KEV.TabIndex = 1;
            groupBoxInput_KEV.TabStop = false;
            groupBoxInput_KEV.Text = "Ввод";
            // 
            // dataGridViewMatrix_KEV
            // 
            dataGridViewMatrix_KEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KEV.Location = new Point(6, 22);
            dataGridViewMatrix_KEV.Name = "dataGridViewMatrix_KEV";
            dataGridViewMatrix_KEV.RowHeadersWidth = 51;
            dataGridViewMatrix_KEV.Size = new Size(454, 206);
            dataGridViewMatrix_KEV.TabIndex = 0;
            // 
            // panelThreee_KEV
            // 
            panelThreee_KEV.Controls.Add(groupBoxInput_KEV);
            panelThreee_KEV.Location = new Point(12, 204);
            panelThreee_KEV.Name = "panelThreee_KEV";
            panelThreee_KEV.Size = new Size(509, 240);
            panelThreee_KEV.TabIndex = 2;
            // 
            // panelTwo_KEV
            // 
            panelTwo_KEV.Controls.Add(groupBoxCondition_KEV);
            panelTwo_KEV.Location = new Point(0, 105);
            panelTwo_KEV.Name = "panelTwo_KEV";
            panelTwo_KEV.Size = new Size(1322, 90);
            panelTwo_KEV.TabIndex = 3;
            // 
            // panelFhore_KEV
            // 
            panelFhore_KEV.Controls.Add(groupBoxConclusion_KEV);
            panelFhore_KEV.Location = new Point(542, 204);
            panelFhore_KEV.Name = "panelFhore_KEV";
            panelFhore_KEV.Size = new Size(509, 240);
            panelFhore_KEV.TabIndex = 3;
            // 
            // groupBoxConclusion_KEV
            // 
            groupBoxConclusion_KEV.Controls.Add(dataGridViewOutMatrix_KEV);
            groupBoxConclusion_KEV.Location = new Point(3, 3);
            groupBoxConclusion_KEV.Name = "groupBoxConclusion_KEV";
            groupBoxConclusion_KEV.Size = new Size(483, 234);
            groupBoxConclusion_KEV.TabIndex = 1;
            groupBoxConclusion_KEV.TabStop = false;
            groupBoxConclusion_KEV.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_KEV
            // 
            dataGridViewOutMatrix_KEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_KEV.Location = new Point(6, 22);
            dataGridViewOutMatrix_KEV.Name = "dataGridViewOutMatrix_KEV";
            dataGridViewOutMatrix_KEV.RowHeadersWidth = 51;
            dataGridViewOutMatrix_KEV.Size = new Size(471, 206);
            dataGridViewOutMatrix_KEV.TabIndex = 0;
            // 
            // openFileDialogTask_KEV
            // 
            openFileDialogTask_KEV.FileName = "openFileDialogTask_KEV";
            // 
            // toolTipButton_KEV
            // 
            toolTipButton_KEV.IsBalloon = true;
            toolTipButton_KEV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 450);
            Controls.Add(panelFhore_KEV);
            Controls.Add(panelTwo_KEV);
            Controls.Add(panelThreee_KEV);
            Controls.Add(panelOne_KEV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Варинт 7 | Киричок Е.В.";
            Load += FormMain_Load;
            panelOne_KEV.ResumeLayout(false);
            groupBoxCondition_KEV.ResumeLayout(false);
            groupBoxCondition_KEV.PerformLayout();
            groupBoxInput_KEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KEV).EndInit();
            panelThreee_KEV.ResumeLayout(false);
            panelTwo_KEV.ResumeLayout(false);
            panelFhore_KEV.ResumeLayout(false);
            groupBoxConclusion_KEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_KEV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOne_KEV;
        private GroupBox groupBoxCondition_KEV;
        private TextBox textBoxCondition_KEV;
        private Button buttonDone_KEV;
        private Button buttonSave_KEV;
        private Button buttonPerform_KEV;
        private Button buttonOpen_KEV;
        private GroupBox groupBoxInput_KEV;
        private Panel panelThreee_KEV;
        private Panel panelTwo_KEV;
        private Panel panelFhore_KEV;
        private GroupBox groupBoxConclusion_KEV;
        private DataGridView dataGridViewMatrix_KEV;
        private DataGridView dataGridViewOutMatrix_KEV;
        private OpenFileDialog openFileDialogTask_KEV;
        private ToolTip toolTipButton_KEV;
        private SaveFileDialog saveFileDialogMatrix_KEV;
    }
}
