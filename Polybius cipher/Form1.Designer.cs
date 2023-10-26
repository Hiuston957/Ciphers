namespace Polybius_cipher
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
            label4 = new Label();
            panel1 = new Panel();
            Run_cipher = new Button();
            InputBox = new TextBox();
            OutputBox = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(183, 18);
            label4.Name = "label4";
            label4.Size = new Size(466, 86);
            label4.TabIndex = 8;
            label4.Text = "Polybius cipher";
            // 
            // panel1
            // 
            panel1.Location = new Point(35, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 150);
            panel1.TabIndex = 9;
            // 
            // Run_cipher
            // 
            Run_cipher.Location = new Point(432, 283);
            Run_cipher.Name = "Run_cipher";
            Run_cipher.Size = new Size(75, 23);
            Run_cipher.TabIndex = 10;
            Run_cipher.Text = "button1";
            Run_cipher.UseVisualStyleBackColor = true;
            Run_cipher.Click += button1_Click;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(467, 166);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(100, 23);
            InputBox.TabIndex = 11;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(655, 166);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(100, 23);
            OutputBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputBox);
            Controls.Add(InputBox);
            Controls.Add(Run_cipher);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Button Run_cipher;
        private TextBox InputBox;
        private TextBox OutputBox;
    }
}