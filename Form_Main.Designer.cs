namespace AverageFinder
{
    partial class Form_Main
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
            this.TotalMarks = new System.Windows.Forms.Label();
            this.NoOfSubjects = new System.Windows.Forms.Label();
            this.TotalMarksTextBox = new System.Windows.Forms.TextBox();
            this.NoOfSubjectsTextBox = new System.Windows.Forms.TextBox();
            this.FindAverageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AverageValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalMarks
            // 
            this.TotalMarks.AutoSize = true;
            this.TotalMarks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarks.Location = new System.Drawing.Point(69, 62);
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.Size = new System.Drawing.Size(111, 25);
            this.TotalMarks.TabIndex = 0;
            this.TotalMarks.Text = "Total Marks";
            // 
            // NoOfSubjects
            // 
            this.NoOfSubjects.AutoSize = true;
            this.NoOfSubjects.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfSubjects.Location = new System.Drawing.Point(43, 112);
            this.NoOfSubjects.Name = "NoOfSubjects";
            this.NoOfSubjects.Size = new System.Drawing.Size(137, 25);
            this.NoOfSubjects.TabIndex = 1;
            this.NoOfSubjects.Text = "No of Subjects";
            // 
            // TotalMarksTextBox
            // 
            this.TotalMarksTextBox.Location = new System.Drawing.Point(227, 62);
            this.TotalMarksTextBox.Name = "TotalMarksTextBox";
            this.TotalMarksTextBox.Size = new System.Drawing.Size(132, 20);
            this.TotalMarksTextBox.TabIndex = 2;
            // 
            // NoOfSubjectsTextBox
            // 
            this.NoOfSubjectsTextBox.Location = new System.Drawing.Point(227, 117);
            this.NoOfSubjectsTextBox.Name = "NoOfSubjectsTextBox";
            this.NoOfSubjectsTextBox.Size = new System.Drawing.Size(132, 20);
            this.NoOfSubjectsTextBox.TabIndex = 3;
            // 
            // FindAverageBtn
            // 
            this.FindAverageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAverageBtn.Location = new System.Drawing.Point(252, 168);
            this.FindAverageBtn.Name = "FindAverageBtn";
            this.FindAverageBtn.Size = new System.Drawing.Size(78, 34);
            this.FindAverageBtn.TabIndex = 4;
            this.FindAverageBtn.Text = "Find Average";
            this.FindAverageBtn.UseVisualStyleBackColor = true;
            this.FindAverageBtn.Click += new System.EventHandler(this.FindAverageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Average";
            // 
            // AverageValue
            // 
            this.AverageValue.AutoSize = true;
            this.AverageValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageValue.Location = new System.Drawing.Point(233, 237);
            this.AverageValue.Name = "AverageValue";
            this.AverageValue.Size = new System.Drawing.Size(23, 25);
            this.AverageValue.TabIndex = 6;
            this.AverageValue.Text = "0";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 330);
            this.Controls.Add(this.AverageValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindAverageBtn);
            this.Controls.Add(this.NoOfSubjectsTextBox);
            this.Controls.Add(this.TotalMarksTextBox);
            this.Controls.Add(this.NoOfSubjects);
            this.Controls.Add(this.TotalMarks);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalMarks;
        private System.Windows.Forms.Label NoOfSubjects;
        private System.Windows.Forms.TextBox TotalMarksTextBox;
        private System.Windows.Forms.TextBox NoOfSubjectsTextBox;
        private System.Windows.Forms.Button FindAverageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AverageValue;
    }
}

