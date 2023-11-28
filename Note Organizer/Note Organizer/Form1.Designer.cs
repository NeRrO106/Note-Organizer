namespace Note_Organizer
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idBoxE = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.ChangeTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(12, 142);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 57);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Note";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(453, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 404);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(172, 25);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Add Notes";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(12, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Note";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteButton);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 227);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(172, 25);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Delete Notes(enter ID)";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(12, 269);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(149, 35);
            this.idBox.TabIndex = 6;
            this.idBox.UseWaitCursor = true;
            // 
            // idBoxE
            // 
            this.idBoxE.Location = new System.Drawing.Point(239, 269);
            this.idBoxE.Multiline = true;
            this.idBoxE.Name = "idBoxE";
            this.idBoxE.Size = new System.Drawing.Size(149, 35);
            this.idBoxE.TabIndex = 9;
            this.idBoxE.UseWaitCursor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(239, 227);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(172, 25);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Edit Notes(id, text)";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(239, 310);
            this.txtE.Multiline = true;
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(149, 35);
            this.txtE.TabIndex = 11;
            this.txtE.UseWaitCursor = true;
            // 
            // editButton
            // 
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(239, 366);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(149, 57);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit Note";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ChangeTheme
            // 
            this.ChangeTheme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeTheme.Location = new System.Drawing.Point(324, 12);
            this.ChangeTheme.Name = "ChangeTheme";
            this.ChangeTheme.Size = new System.Drawing.Size(87, 32);
            this.ChangeTheme.TabIndex = 13;
            this.ChangeTheme.Text = "DarkMode";
            this.ChangeTheme.UseVisualStyleBackColor = true;
            this.ChangeTheme.Click += new System.EventHandler(this.ChangeTheme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeTheme);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.idBoxE);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox idBoxE;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button ChangeTheme;
    }
}

