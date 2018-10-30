namespace Library
{
    partial class MakeLoanDialog
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonCreateLoan = new System.Windows.Forms.Button();
            this.labelTimeOfLoan = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time of loan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(54, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // buttonCreateLoan
            // 
            this.buttonCreateLoan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreateLoan.Location = new System.Drawing.Point(54, 272);
            this.buttonCreateLoan.Name = "buttonCreateLoan";
            this.buttonCreateLoan.Size = new System.Drawing.Size(97, 23);
            this.buttonCreateLoan.TabIndex = 8;
            this.buttonCreateLoan.Text = "Create Loan";
            this.buttonCreateLoan.UseVisualStyleBackColor = true;
            this.buttonCreateLoan.Click += new System.EventHandler(this.buttonCreateLoan_Click);
            // 
            // labelTimeOfLoan
            // 
            this.labelTimeOfLoan.AutoSize = true;
            this.labelTimeOfLoan.Location = new System.Drawing.Point(54, 168);
            this.labelTimeOfLoan.Name = "labelTimeOfLoan";
            this.labelTimeOfLoan.Size = new System.Drawing.Size(46, 17);
            this.labelTimeOfLoan.TabIndex = 9;
            this.labelTimeOfLoan.Text = "label5";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(54, 225);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(46, 17);
            this.labelDueDate.TabIndex = 10;
            this.labelDueDate.Text = "label6";
            // 
            // MakeLoanDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 421);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelTimeOfLoan);
            this.Controls.Add(this.buttonCreateLoan);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MakeLoanDialog";
            this.Text = "MakeLoanDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonCreateLoan;
        private System.Windows.Forms.Label labelTimeOfLoan;
        private System.Windows.Forms.Label labelDueDate;
    }
}