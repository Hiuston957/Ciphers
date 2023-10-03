namespace Criphers
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
            Input1 = new TextBox();
            label1 = new Label();
            Output1 = new TextBox();
            Button_start = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            KeyBox1 = new ListBox();
            groupBox1 = new GroupBox();
            decrypt1 = new RadioButton();
            encrypt1 = new RadioButton();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Input1
            // 
            Input1.Location = new Point(27, 228);
            Input1.Multiline = true;
            Input1.Name = "Input1";
            Input1.Size = new Size(208, 94);
            Input1.TabIndex = 0;
            Input1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 200);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Normal text (input):";
            label1.Click += label1_Click;
            // 
            // Output1
            // 
            Output1.Location = new Point(585, 228);
            Output1.Multiline = true;
            Output1.Name = "Output1";
            Output1.ReadOnly = true;
            Output1.Size = new Size(208, 94);
            Output1.TabIndex = 3;
            // 
            // Button_start
            // 
            Button_start.Location = new Point(437, 213);
            Button_start.Name = "Button_start";
            Button_start.Size = new Size(75, 51);
            Button_start.TabIndex = 4;
            Button_start.Text = "Run encryption";
            Button_start.UseVisualStyleBackColor = true;
            Button_start.Click += Button_start_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 200);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Key:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 200);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 6;
            label3.Text = "Ciphertext (output):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(222, 50);
            label4.Name = "label4";
            label4.Size = new Size(436, 86);
            label4.TabIndex = 7;
            label4.Text = "Caesar cipher ";
            label4.Click += label4_Click;
            // 
            // KeyBox1
            // 
            KeyBox1.FormattingEnabled = true;
            KeyBox1.ItemHeight = 15;
            KeyBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34" });
            KeyBox1.Location = new Point(253, 228);
            KeyBox1.Name = "KeyBox1";
            KeyBox1.Size = new Size(120, 94);
            KeyBox1.TabIndex = 8;
            KeyBox1.SelectedIndexChanged += KeyBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(decrypt1);
            groupBox1.Controls.Add(encrypt1);
            groupBox1.Location = new Point(411, 287);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 100);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action type";
            // 
            // decrypt1
            // 
            decrypt1.AutoSize = true;
            decrypt1.Location = new Point(44, 55);
            decrypt1.Name = "decrypt1";
            decrypt1.Size = new Size(65, 19);
            decrypt1.TabIndex = 1;
            decrypt1.TabStop = true;
            decrypt1.Text = "decrypt";
            decrypt1.UseVisualStyleBackColor = true;
            decrypt1.CheckedChanged += decrypt1_CheckedChanged;
            // 
            // encrypt1
            // 
            encrypt1.AutoSize = true;
            encrypt1.Location = new Point(44, 30);
            encrypt1.Name = "encrypt1";
            encrypt1.Size = new Size(65, 19);
            encrypt1.TabIndex = 0;
            encrypt1.TabStop = true;
            encrypt1.Text = "encrypt";
            encrypt1.UseVisualStyleBackColor = true;
            encrypt1.CheckedChanged += encrypt1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(730, 450);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 13;
            label5.Text = "created by: 14546 ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 474);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(KeyBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Button_start);
            Controls.Add(Output1);
            Controls.Add(label1);
            Controls.Add(Input1);
            Name = "Form1";
            Text = "Caesar Cipher ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input1;
        private Label label1;
        private TextBox Key1;
        private TextBox Output1;
        private Button Button_start;
        private Label label2;
        private Label label3;
        private Label label4;

        public ListBox KeyList { get; private set; }

        private ListBox listBox1;
        private ListBox KeyBox1;
        private CheckBox decrypt;
        private CheckBox encrypt;
        private GroupBox groupBox1;
        private RadioButton decrypt1;
        private RadioButton encrypt1;
        private Label label5;
    }
}