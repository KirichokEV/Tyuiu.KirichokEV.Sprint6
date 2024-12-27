namespace Tyuiu.KirichokEV.Sprint6.Task7.V7
{
    partial class FormAbout_KEV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KEV));
            textBoxInform_KEV = new TextBox();
            pictureBoxInform_KEV = new PictureBox();
            buttonOk_KEV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInform_KEV).BeginInit();
            SuspendLayout();
            // 
            // textBoxInform_KEV
            // 
            textBoxInform_KEV.Location = new Point(218, 12);
            textBoxInform_KEV.Multiline = true;
            textBoxInform_KEV.Name = "textBoxInform_KEV";
            textBoxInform_KEV.ReadOnly = true;
            textBoxInform_KEV.Size = new Size(339, 234);
            textBoxInform_KEV.TabIndex = 1;
            textBoxInform_KEV.Text = resources.GetString("textBoxInform_KEV.Text");
            // 
            // pictureBoxInform_KEV
            // 
            pictureBoxInform_KEV.Image = (Image)resources.GetObject("pictureBoxInform_KEV.Image");
            pictureBoxInform_KEV.Location = new Point(12, 12);
            pictureBoxInform_KEV.Name = "pictureBoxInform_KEV";
            pictureBoxInform_KEV.Size = new Size(170, 169);
            pictureBoxInform_KEV.TabIndex = 2;
            pictureBoxInform_KEV.TabStop = false;
            // 
            // buttonOk_KEV
            // 
            buttonOk_KEV.Location = new Point(431, 252);
            buttonOk_KEV.Name = "buttonOk_KEV";
            buttonOk_KEV.Size = new Size(94, 29);
            buttonOk_KEV.TabIndex = 3;
            buttonOk_KEV.Text = "OK";
            buttonOk_KEV.UseVisualStyleBackColor = true;
            buttonOk_KEV.Click += buttonOk_KEV_Click;
            // 
            // FormAbout_KEV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 291);
            Controls.Add(buttonOk_KEV);
            Controls.Add(pictureBoxInform_KEV);
            Controls.Add(textBoxInform_KEV);
            Name = "FormAbout_KEV";
            Text = "FormAbout_KEV";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInform_KEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInform_KEV;
        private PictureBox pictureBoxInform_KEV;
        private Button buttonOk_KEV;
    }
}