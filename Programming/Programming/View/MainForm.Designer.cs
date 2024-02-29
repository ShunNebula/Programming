namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBoxSeason = new System.Windows.Forms.GroupBox();
            this.ComboBoxSeason = new System.Windows.Forms.ComboBox();
            this.ButtonSeason = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonParse = new System.Windows.Forms.Button();
            this.TextBoxParsing = new System.Windows.Forms.TextBox();
            this.LabelParsing2 = new System.Windows.Forms.Label();
            this.LabelParsing1 = new System.Windows.Forms.Label();
            this.Enumeration = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.GroupBoxSeason.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Enumeration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GroupBoxSeason);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.Enumeration);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Enums";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeason
            // 
            this.GroupBoxSeason.Controls.Add(this.ComboBoxSeason);
            this.GroupBoxSeason.Controls.Add(this.ButtonSeason);
            this.GroupBoxSeason.Controls.Add(this.label4);
            this.GroupBoxSeason.Location = new System.Drawing.Point(376, 221);
            this.GroupBoxSeason.Name = "GroupBoxSeason";
            this.GroupBoxSeason.Size = new System.Drawing.Size(377, 140);
            this.GroupBoxSeason.TabIndex = 8;
            this.GroupBoxSeason.TabStop = false;
            this.GroupBoxSeason.Text = "Season Handle";
            // 
            // ComboBoxSeason
            // 
            this.ComboBoxSeason.FormattingEnabled = true;
            this.ComboBoxSeason.Location = new System.Drawing.Point(20, 47);
            this.ComboBoxSeason.Name = "ComboBoxSeason";
            this.ComboBoxSeason.Size = new System.Drawing.Size(156, 21);
            this.ComboBoxSeason.TabIndex = 3;
            // 
            // ButtonSeason
            // 
            this.ButtonSeason.Location = new System.Drawing.Point(183, 43);
            this.ButtonSeason.Name = "ButtonSeason";
            this.ButtonSeason.Size = new System.Drawing.Size(75, 23);
            this.ButtonSeason.TabIndex = 2;
            this.ButtonSeason.Text = "button1";
            this.ButtonSeason.UseVisualStyleBackColor = true;
            this.ButtonSeason.Click += new System.EventHandler(this.ButtonSeason_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonParse);
            this.groupBox1.Controls.Add(this.TextBoxParsing);
            this.groupBox1.Controls.Add(this.LabelParsing2);
            this.groupBox1.Controls.Add(this.LabelParsing1);
            this.groupBox1.Location = new System.Drawing.Point(8, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 140);
            this.groupBox1.TabIndex = 7;
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
            // Enumeration
            // 
            this.Enumeration.Controls.Add(this.ValuesListBox);
            this.Enumeration.Controls.Add(this.label3);
            this.Enumeration.Controls.Add(this.EnumsListBox);
            this.Enumeration.Controls.Add(this.label2);
            this.Enumeration.Controls.Add(this.EnumsTextBox);
            this.Enumeration.Controls.Add(this.label1);
            this.Enumeration.Location = new System.Drawing.Point(8, 3);
            this.Enumeration.Name = "Enumeration";
            this.Enumeration.Size = new System.Drawing.Size(745, 211);
            this.Enumeration.TabIndex = 6;
            this.Enumeration.TabStop = false;
            this.Enumeration.Text = "Enumeration";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(183, 39);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 95);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 39);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 95);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // EnumsTextBox
            // 
            this.EnumsTextBox.Location = new System.Drawing.Point(365, 39);
            this.EnumsTextBox.Name = "EnumsTextBox";
            this.EnumsTextBox.ReadOnly = true;
            this.EnumsTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnumsTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.GroupBoxSeason.ResumeLayout(false);
            this.GroupBoxSeason.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Enumeration.ResumeLayout(false);
            this.Enumeration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox EnumsTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Enumeration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonParse;
        private System.Windows.Forms.TextBox TextBoxParsing;
        private System.Windows.Forms.Label LabelParsing2;
        private System.Windows.Forms.Label LabelParsing1;
        private System.Windows.Forms.GroupBox GroupBoxSeason;
        private System.Windows.Forms.ComboBox ComboBoxSeason;
        private System.Windows.Forms.Button ButtonSeason;
        private System.Windows.Forms.Label label4;
    }
}

