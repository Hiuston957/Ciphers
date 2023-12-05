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
            Run_encrypt = new Button();
            InputBox = new TextBox();
            OutputBox = new TextBox();
            Run_decipt = new Button();
            InputLabel = new Label();
            OutputLabel = new Label();
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
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(35, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 150);
            panel1.TabIndex = 9;
            // 
            // Run_encrypt
            // 
            Run_encrypt.Location = new Point(545, 226);
            Run_encrypt.Name = "Run_encrypt";
            Run_encrypt.Size = new Size(146, 23);
            Run_encrypt.TabIndex = 10;
            Run_encrypt.Text = "Run encryption";
            Run_encrypt.UseVisualStyleBackColor = true;
            Run_encrypt.Click += button1_Click;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(467, 166);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(100, 23);
            InputBox.TabIndex = 11;
            InputBox.TextChanged += InputBox_TextChanged;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(655, 166);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(100, 23);
            OutputBox.TabIndex = 12;
            // 
            // Run_decipt
            // 
            Run_decipt.Location = new Point(545, 269);
            Run_decipt.Name = "Run_decipt";
            Run_decipt.Size = new Size(146, 23);
            Run_decipt.TabIndex = 13;
            Run_decipt.Text = "Run decryption";
            Run_decipt.UseVisualStyleBackColor = true;
            Run_decipt.Click += Run_decipher_Click;
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InputLabel.Location = new Point(426, 169);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(35, 15);
            InputLabel.TabIndex = 14;
            InputLabel.Text = "Input";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OutputLabel.Location = new Point(604, 169);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(45, 15);
            OutputLabel.TabIndex = 15;
            OutputLabel.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputLabel);
            Controls.Add(InputLabel);
            Controls.Add(Run_decipt);
            Controls.Add(OutputBox);
            Controls.Add(InputBox);
            Controls.Add(Run_encrypt);
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
        private Button Run_encrypt;
        private TextBox InputBox;
        private TextBox OutputBox;
        private Button Run_decipt;
        private Label InputLabel;
        private Label OutputLabel;
    }
}