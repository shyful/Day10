namespace SalaryCalculatorApp
{
    partial class SalaryCalculatorUI
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
            this.employeenametextBox = new System.Windows.Forms.TextBox();
            this.basic_AmounttextBox = new System.Windows.Forms.TextBox();
            this.house_RenttextBox = new System.Windows.Forms.TextBox();
            this.medical_AllowancetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeSalary Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // employeenametextBox
            // 
            this.employeenametextBox.Location = new System.Drawing.Point(181, 33);
            this.employeenametextBox.Name = "employeenametextBox";
            this.employeenametextBox.Size = new System.Drawing.Size(254, 20);
            this.employeenametextBox.TabIndex = 4;
            // 
            // basic_AmounttextBox
            // 
            this.basic_AmounttextBox.Location = new System.Drawing.Point(181, 87);
            this.basic_AmounttextBox.Name = "basic_AmounttextBox";
            this.basic_AmounttextBox.Size = new System.Drawing.Size(171, 20);
            this.basic_AmounttextBox.TabIndex = 5;
            // 
            // house_RenttextBox
            // 
            this.house_RenttextBox.Location = new System.Drawing.Point(181, 148);
            this.house_RenttextBox.Name = "house_RenttextBox";
            this.house_RenttextBox.Size = new System.Drawing.Size(171, 20);
            this.house_RenttextBox.TabIndex = 6;
            // 
            // medical_AllowancetextBox
            // 
            this.medical_AllowancetextBox.Location = new System.Drawing.Point(181, 208);
            this.medical_AllowancetextBox.Name = "medical_AllowancetextBox";
            this.medical_AllowancetextBox.Size = new System.Drawing.Size(171, 20);
            this.medical_AllowancetextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "% of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "% of Basic";
            // 
            // salaryButton
            // 
            this.salaryButton.Location = new System.Drawing.Point(199, 340);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(75, 23);
            this.salaryButton.TabIndex = 10;
            this.salaryButton.Text = "Show Salary";
            this.salaryButton.UseVisualStyleBackColor = true;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // SalaryCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 443);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.medical_AllowancetextBox);
            this.Controls.Add(this.house_RenttextBox);
            this.Controls.Add(this.basic_AmounttextBox);
            this.Controls.Add(this.employeenametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculatorUI";
            this.Text = "Salary Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeenametextBox;
        private System.Windows.Forms.TextBox basic_AmounttextBox;
        private System.Windows.Forms.TextBox house_RenttextBox;
        private System.Windows.Forms.TextBox medical_AllowancetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button salaryButton;
    }
}

