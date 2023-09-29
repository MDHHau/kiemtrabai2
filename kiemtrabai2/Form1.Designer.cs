namespace kiemtrabai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCou = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.txt10 = new System.Windows.Forms.RadioButton();
            this.txt50 = new System.Windows.Forms.RadioButton();
            this.txt100 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Year";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(150, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(127, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtCou
            // 
            this.txtCou.Location = new System.Drawing.Point(150, 129);
            this.txtCou.Name = "txtCou";
            this.txtCou.Size = new System.Drawing.Size(127, 22);
            this.txtCou.TabIndex = 1;
            // 
            // txtyear
            // 
            this.txtyear.FormattingEnabled = true;
            this.txtyear.Location = new System.Drawing.Point(150, 197);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(120, 24);
            this.txtyear.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt100);
            this.groupBox1.Controls.Add(this.txt50);
            this.groupBox1.Controls.Add(this.txt10);
            this.groupBox1.Location = new System.Drawing.Point(31, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit";
            // 
            // txtUni
            // 
            this.txtUni.Location = new System.Drawing.Point(125, 399);
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(189, 22);
            this.txtUni.TabIndex = 5;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(193, 457);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(83, 35);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txt10
            // 
            this.txt10.AutoSize = true;
            this.txt10.Location = new System.Drawing.Point(44, 35);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(54, 20);
            this.txt10.TabIndex = 0;
            this.txt10.TabStop = true;
            this.txt10.Text = "10%";
            this.txt10.UseVisualStyleBackColor = true;
            // 
            // txt50
            // 
            this.txt50.AutoSize = true;
            this.txt50.Location = new System.Drawing.Point(192, 36);
            this.txt50.Name = "txt50";
            this.txt50.Size = new System.Drawing.Size(54, 20);
            this.txt50.TabIndex = 1;
            this.txt50.TabStop = true;
            this.txt50.Text = "50%";
            this.txt50.UseVisualStyleBackColor = true;
            // 
            // txt100
            // 
            this.txt100.AutoSize = true;
            this.txt100.Location = new System.Drawing.Point(325, 36);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(61, 20);
            this.txt100.TabIndex = 1;
            this.txt100.TabStop = true;
            this.txt100.Text = "100%";
            this.txt100.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 501);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtUni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtCou);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCou;
        private System.Windows.Forms.ComboBox txtyear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.RadioButton txt100;
        private System.Windows.Forms.RadioButton txt50;
        private System.Windows.Forms.RadioButton txt10;
    }
}

