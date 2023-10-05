namespace WindowsFormsApp3
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
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subBtn = new System.Windows.Forms.Button();
            this.openPicBox = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.passBtr = new System.Windows.Forms.Button();
            this.undorBtr = new System.Windows.Forms.Button();
            this.redoBtr = new System.Windows.Forms.Button();
            this.cutBtr = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.visBtr = new System.Windows.Forms.RadioButton();
            this.masterBtr = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cardType = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.openPicBox)).BeginInit();
            this.cardType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameTxt.Location = new System.Drawing.Point(153, 24);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(215, 38);
            this.userNameTxt.TabIndex = 12;
            // 
            // passTxtBox
            // 
            this.passTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTxtBox.Location = new System.Drawing.Point(153, 96);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(215, 38);
            this.passTxtBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subBtn.Location = new System.Drawing.Point(254, 157);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(114, 42);
            this.subBtn.TabIndex = 16;
            this.subBtn.Text = "Submit";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // openPicBox
            // 
            this.openPicBox.Image = global::WindowsFormsApp3.Properties.Resources.hidden_2355322;
            this.openPicBox.Location = new System.Drawing.Point(381, 98);
            this.openPicBox.Name = "openPicBox";
            this.openPicBox.Size = new System.Drawing.Size(34, 35);
            this.openPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openPicBox.TabIndex = 17;
            this.openPicBox.TabStop = false;
            this.openPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openPicBox_MouseDown);
            this.openPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openPicBox_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(107, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(241, 158);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyBtn.Location = new System.Drawing.Point(283, 209);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(63, 43);
            this.copyBtn.TabIndex = 19;
            this.copyBtn.Text = "COPY BUTTON";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // passBtr
            // 
            this.passBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBtr.Location = new System.Drawing.Point(195, 209);
            this.passBtr.Name = "passBtr";
            this.passBtr.Size = new System.Drawing.Size(63, 43);
            this.passBtr.TabIndex = 20;
            this.passBtr.Text = "PAST BUTTON";
            this.passBtr.UseVisualStyleBackColor = true;
            this.passBtr.Click += new System.EventHandler(this.passBtr_Click);
            // 
            // undorBtr
            // 
            this.undorBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undorBtr.Location = new System.Drawing.Point(107, 209);
            this.undorBtr.Name = "undorBtr";
            this.undorBtr.Size = new System.Drawing.Size(63, 43);
            this.undorBtr.TabIndex = 21;
            this.undorBtr.Text = "UNDOR BUTTON";
            this.undorBtr.UseVisualStyleBackColor = true;
            this.undorBtr.Click += new System.EventHandler(this.button1_Click);
            // 
            // redoBtr
            // 
            this.redoBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redoBtr.Location = new System.Drawing.Point(19, 209);
            this.redoBtr.Name = "redoBtr";
            this.redoBtr.Size = new System.Drawing.Size(63, 43);
            this.redoBtr.TabIndex = 22;
            this.redoBtr.Text = "REDO BUTTON";
            this.redoBtr.UseVisualStyleBackColor = true;
            this.redoBtr.Click += new System.EventHandler(this.redoBtr_Click);
            // 
            // cutBtr
            // 
            this.cutBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cutBtr.Location = new System.Drawing.Point(352, 209);
            this.cutBtr.Name = "cutBtr";
            this.cutBtr.Size = new System.Drawing.Size(63, 43);
            this.cutBtr.TabIndex = 23;
            this.cutBtr.Text = "CUT BUTTON";
            this.cutBtr.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(63, 297);
            this.maskedTextBox1.Mask = "000-000-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(160, 20);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // visBtr
            // 
            this.visBtr.AutoSize = true;
            this.visBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visBtr.Location = new System.Drawing.Point(19, 19);
            this.visBtr.Name = "visBtr";
            this.visBtr.Size = new System.Drawing.Size(62, 24);
            this.visBtr.TabIndex = 25;
            this.visBtr.TabStop = true;
            this.visBtr.Text = "Visa";
            this.visBtr.UseVisualStyleBackColor = true;
            this.visBtr.CheckedChanged += new System.EventHandler(this.visBtr_CheckedChanged);
            // 
            // masterBtr
            // 
            this.masterBtr.AutoSize = true;
            this.masterBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterBtr.Location = new System.Drawing.Point(19, 42);
            this.masterBtr.Name = "masterBtr";
            this.masterBtr.Size = new System.Drawing.Size(82, 24);
            this.masterBtr.TabIndex = 26;
            this.masterBtr.TabStop = true;
            this.masterBtr.Text = "Master";
            this.masterBtr.UseVisualStyleBackColor = true;
            this.masterBtr.CheckedChanged += new System.EventHandler(this.masterBtr_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(37, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 24);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EN";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(37, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 24);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AZ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cardType
            // 
            this.cardType.Controls.Add(this.visBtr);
            this.cardType.Controls.Add(this.masterBtr);
            this.cardType.Location = new System.Drawing.Point(31, 421);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(151, 95);
            this.cardType.TabIndex = 30;
            this.cardType.TabStop = false;
            this.cardType.Text = "groupBox2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(200, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 95);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(50, 547);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 29);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "33 yasim var";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(50, 594);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(165, 29);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "33 yasim var";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(271, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "change all color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(428, 421);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.cutBtr);
            this.groupBox1.Controls.Add(this.copyBtn);
            this.groupBox1.Controls.Add(this.passBtr);
            this.groupBox1.Controls.Add(this.undorBtr);
            this.groupBox1.Controls.Add(this.redoBtr);
            this.groupBox1.Location = new System.Drawing.Point(605, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 295);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(960, 343);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 29);
            this.checkBox3.TabIndex = 38;
            this.checkBox3.Text = "Show";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1115, 751);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cardType);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.openPicBox);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.userNameTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openPicBox)).EndInit();
            this.cardType.ResumeLayout(false);
            this.cardType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.PictureBox openPicBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button passBtr;
        private System.Windows.Forms.Button undorBtr;
        private System.Windows.Forms.Button redoBtr;
        private System.Windows.Forms.Button cutBtr;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton visBtr;
        private System.Windows.Forms.RadioButton masterBtr;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox cardType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

