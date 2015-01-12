namespace CalculatorApp
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
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.second_NumbertextBox = new System.Windows.Forms.TextBox();
            this.first_NumbertextBox = new System.Windows.Forms.TextBox();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // resulttextBox
            // 
            this.resulttextBox.Location = new System.Drawing.Point(193, 155);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(258, 20);
            this.resulttextBox.TabIndex = 3;
            // 
            // second_NumbertextBox
            // 
            this.second_NumbertextBox.Location = new System.Drawing.Point(193, 100);
            this.second_NumbertextBox.Name = "second_NumbertextBox";
            this.second_NumbertextBox.Size = new System.Drawing.Size(258, 20);
            this.second_NumbertextBox.TabIndex = 4;
            // 
            // first_NumbertextBox
            // 
            this.first_NumbertextBox.Location = new System.Drawing.Point(193, 45);
            this.first_NumbertextBox.Name = "first_NumbertextBox";
            this.first_NumbertextBox.Size = new System.Drawing.Size(258, 20);
            this.first_NumbertextBox.TabIndex = 5;
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(45, 304);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(75, 23);
            this.additionButton.TabIndex = 6;
            this.additionButton.Text = "Add";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(171, 304);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(75, 23);
            this.subtractionButton.TabIndex = 7;
            this.subtractionButton.Text = "Subtract";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(318, 304);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(75, 23);
            this.multiplicationButton.TabIndex = 8;
            this.multiplicationButton.Text = "Multiply";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(447, 304);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 23);
            this.divisionButton.TabIndex = 9;
            this.divisionButton.Text = "Divide";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 413);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.first_NumbertextBox);
            this.Controls.Add(this.second_NumbertextBox);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resulttextBox;
        private System.Windows.Forms.TextBox second_NumbertextBox;
        private System.Windows.Forms.TextBox first_NumbertextBox;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
    }
}

