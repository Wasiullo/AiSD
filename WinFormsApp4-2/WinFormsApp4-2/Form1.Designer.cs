namespace WinFormsApp4_2
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
            button1 = new Button();
            textBox1 = new TextBox();
            treeView1 = new TreeView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(101, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(508, 40);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(250, 267);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // button2
            // 
            button2.Location = new Point(575, 327);
            button2.Name = "button2";
            button2.Size = new Size(123, 53);
            button2.TabIndex = 3;
            button2.Text = "wyswietl drzewo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 371);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "InOrder";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(167, 371);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "PreOrder";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(316, 371);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "PostOrder";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 327);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(379, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 309);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 8;
            label1.Text = "Wynik:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 31);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 9;
            label2.Text = "Podaj element:";
            // 
            // button6
            // 
            button6.Location = new Point(101, 107);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "usuń";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(treeView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TreeView treeView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button6;
    }
}
