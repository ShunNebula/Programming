namespace Programming.View.Panels
{
    partial class WeekdayControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonParse = new System.Windows.Forms.Button();
            this.TextBoxParsing = new System.Windows.Forms.TextBox();
            this.LabelParsing2 = new System.Windows.Forms.Label();
            this.LabelParsing1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonParse);
            this.groupBox1.Controls.Add(this.TextBoxParsing);
            this.groupBox1.Controls.Add(this.LabelParsing2);
            this.groupBox1.Controls.Add(this.LabelParsing1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weekday Parsing";
            // 
            // ButtonParse
            // 
            this.ButtonParse.Location = new System.Drawing.Point(186, 44);
            this.ButtonParse.Name = "ButtonParse";
            this.ButtonParse.Size = new System.Drawing.Size(75, 23);
            this.ButtonParse.TabIndex = 3;
            this.ButtonParse.Text = "Parse";
            this.ButtonParse.UseVisualStyleBackColor = true;
            this.ButtonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // TextBoxParsing
            // 
            this.TextBoxParsing.Location = new System.Drawing.Point(19, 47);
            this.TextBoxParsing.Name = "TextBoxParsing";
            this.TextBoxParsing.Size = new System.Drawing.Size(153, 20);
            this.TextBoxParsing.TabIndex = 2;
            // 
            // LabelParsing2
            // 
            this.LabelParsing2.AutoSize = true;
            this.LabelParsing2.Location = new System.Drawing.Point(16, 83);
            this.LabelParsing2.Name = "LabelParsing2";
            this.LabelParsing2.Size = new System.Drawing.Size(13, 13);
            this.LabelParsing2.TabIndex = 1;
            this.LabelParsing2.Text = "0";
            // 
            // LabelParsing1
            // 
            this.LabelParsing1.AutoSize = true;
            this.LabelParsing1.Location = new System.Drawing.Point(16, 30);
            this.LabelParsing1.Name = "LabelParsing1";
            this.LabelParsing1.Size = new System.Drawing.Size(112, 13);
            this.LabelParsing1.TabIndex = 0;
            this.LabelParsing1.Text = "Type value for parsing";
            // 
            // WeekdayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "WeekdayControl";
            this.Size = new System.Drawing.Size(352, 147);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonParse;
        private System.Windows.Forms.TextBox TextBoxParsing;
        private System.Windows.Forms.Label LabelParsing2;
        private System.Windows.Forms.Label LabelParsing1;
    }
}
