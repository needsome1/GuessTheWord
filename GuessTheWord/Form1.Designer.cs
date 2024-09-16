namespace GuessTheWord
{
    partial class Form1
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
            label1 = new Label();
            lblWord = new Label();
            textBox1 = new TextBox();
            lblInfo = new Label();
            lblGuessed = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 54);
            label1.TabIndex = 0;
            label1.Text = "Guess the word";
            // 
            // lblWord
            // 
            lblWord.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblWord.Location = new Point(103, 63);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(571, 61);
            lblWord.TabIndex = 1;
            lblWord.Text = "label2";
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(231, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 57);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += KeyIsPressed;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblInfo.Location = new Point(231, 291);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(298, 61);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Words: 0 of 0";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuessed
            // 
            lblGuessed.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGuessed.Location = new Point(550, 172);
            lblGuessed.Name = "lblGuessed";
            lblGuessed.Size = new Size(239, 85);
            lblGuessed.TabIndex = 1;
            lblGuessed.Text = "Guessed: 0 times";
            lblGuessed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblGuessed);
            Controls.Add(lblInfo);
            Controls.Add(lblWord);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Guess The Word";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWord;
        private TextBox textBox1;
        private Label lblInfo;
        private Label lblGuessed;
    }
}
