namespace ObjectOrientedPractices.View
{
    partial class Check
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
            this.CloneTextBox = new System.Windows.Forms.TextBox();
            this.EqualsTextBox = new System.Windows.Forms.TextBox();
            this.CompareTextBox = new System.Windows.Forms.TextBox();
            this.Equals2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equals1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compare:";
            // 
            // CloneTextBox
            // 
            this.CloneTextBox.Location = new System.Drawing.Point(74, 6);
            this.CloneTextBox.Name = "CloneTextBox";
            this.CloneTextBox.Size = new System.Drawing.Size(100, 20);
            this.CloneTextBox.TabIndex = 3;
            // 
            // EqualsTextBox
            // 
            this.EqualsTextBox.Location = new System.Drawing.Point(74, 32);
            this.EqualsTextBox.Name = "EqualsTextBox";
            this.EqualsTextBox.Size = new System.Drawing.Size(100, 20);
            this.EqualsTextBox.TabIndex = 4;
            // 
            // CompareTextBox
            // 
            this.CompareTextBox.Location = new System.Drawing.Point(74, 84);
            this.CompareTextBox.Name = "CompareTextBox";
            this.CompareTextBox.Size = new System.Drawing.Size(100, 20);
            this.CompareTextBox.TabIndex = 5;
            // 
            // Equals2TextBox
            // 
            this.Equals2TextBox.Location = new System.Drawing.Point(74, 58);
            this.Equals2TextBox.Name = "Equals2TextBox";
            this.Equals2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Equals2TextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Equals2:";
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 117);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Equals2TextBox);
            this.Controls.Add(this.CompareTextBox);
            this.Controls.Add(this.EqualsTextBox);
            this.Controls.Add(this.CloneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Check";
            this.Text = "Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CloneTextBox;
        private System.Windows.Forms.TextBox EqualsTextBox;
        private System.Windows.Forms.TextBox CompareTextBox;
        private System.Windows.Forms.TextBox Equals2TextBox;
        private System.Windows.Forms.Label label4;
    }
}