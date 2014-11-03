namespace COMP1004_Lesson09
{
    partial class SummaryForm
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
            this.totalSalexTextBox = new System.Windows.Forms.TextBox();
            this.averageSalesTextBox = new System.Windows.Forms.TextBox();
            this.numberCustomersTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Sales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Customers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average Sales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "R\' and R for reading and refreshments";
            // 
            // totalSalexTextBox
            // 
            this.totalSalexTextBox.Location = new System.Drawing.Point(157, 43);
            this.totalSalexTextBox.Name = "totalSalexTextBox";
            this.totalSalexTextBox.ReadOnly = true;
            this.totalSalexTextBox.Size = new System.Drawing.Size(183, 20);
            this.totalSalexTextBox.TabIndex = 4;
            this.totalSalexTextBox.TabStop = false;
            // 
            // averageSalesTextBox
            // 
            this.averageSalesTextBox.Location = new System.Drawing.Point(157, 76);
            this.averageSalesTextBox.Name = "averageSalesTextBox";
            this.averageSalesTextBox.ReadOnly = true;
            this.averageSalesTextBox.Size = new System.Drawing.Size(183, 20);
            this.averageSalesTextBox.TabIndex = 5;
            this.averageSalesTextBox.TabStop = false;
            // 
            // numberCustomersTextBox
            // 
            this.numberCustomersTextBox.Location = new System.Drawing.Point(157, 109);
            this.numberCustomersTextBox.Name = "numberCustomersTextBox";
            this.numberCustomersTextBox.ReadOnly = true;
            this.numberCustomersTextBox.Size = new System.Drawing.Size(183, 20);
            this.numberCustomersTextBox.TabIndex = 6;
            this.numberCustomersTextBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(119, 157);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(136, 30);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 218);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.numberCustomersTextBox);
            this.Controls.Add(this.averageSalesTextBox);
            this.Controls.Add(this.totalSalexTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Summary";
            this.Activated += new System.EventHandler(this.SummaryForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalSalexTextBox;
        private System.Windows.Forms.TextBox averageSalesTextBox;
        private System.Windows.Forms.TextBox numberCustomersTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}