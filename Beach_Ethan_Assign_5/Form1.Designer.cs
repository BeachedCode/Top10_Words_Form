namespace Beach_Ethan_Assign_5
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
            label2 = new Label();
            txtFilePath1 = new TextBox();
            txtFilePath2 = new TextBox();
            btnBrowse1 = new Button();
            btnBrowse2 = new Button();
            btnSubmit = new Button();
            btnExit = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 67);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Book 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 70);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Book 2";
            // 
            // txtFilePath1
            // 
            txtFilePath1.Location = new Point(92, 67);
            txtFilePath1.Name = "txtFilePath1";
            txtFilePath1.Size = new Size(197, 31);
            txtFilePath1.TabIndex = 2;
            // 
            // txtFilePath2
            // 
            txtFilePath2.Location = new Point(514, 67);
            txtFilePath2.Name = "txtFilePath2";
            txtFilePath2.Size = new Size(197, 31);
            txtFilePath2.TabIndex = 3;
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(295, 67);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(112, 34);
            btnBrowse1.TabIndex = 4;
            btnBrowse1.Text = "Browse";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(717, 65);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(112, 34);
            btnBrowse2.TabIndex = 5;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(295, 122);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(449, 122);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(49, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(380, 329);
            listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(461, 180);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(380, 329);
            listBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 534);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse2);
            Controls.Add(btnBrowse1);
            Controls.Add(txtFilePath2);
            Controls.Add(txtFilePath1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFilePath1;
        private TextBox txtFilePath2;
        private Button btnBrowse1;
        private Button btnBrowse2;
        private Button btnSubmit;
        private Button btnExit;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}