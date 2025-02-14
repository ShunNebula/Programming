namespace Programming.View.Panels
{
    partial class EnumerationControl
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
            this.Enumeration = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.LabelInt = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.LabelChooseValue = new System.Windows.Forms.Label();
            this.EnumsTextBox = new System.Windows.Forms.TextBox();
            this.LabelChooseEnum = new System.Windows.Forms.Label();
            this.Enumeration.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enumeration
            // 
            this.Enumeration.Controls.Add(this.ValuesListBox);
            this.Enumeration.Controls.Add(this.LabelInt);
            this.Enumeration.Controls.Add(this.EnumsListBox);
            this.Enumeration.Controls.Add(this.LabelChooseValue);
            this.Enumeration.Controls.Add(this.EnumsTextBox);
            this.Enumeration.Controls.Add(this.LabelChooseEnum);
            this.Enumeration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enumeration.Location = new System.Drawing.Point(0, 0);
            this.Enumeration.Name = "Enumeration";
            this.Enumeration.Size = new System.Drawing.Size(754, 218);
            this.Enumeration.TabIndex = 7;
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
            // LabelInt
            // 
            this.LabelInt.AutoSize = true;
            this.LabelInt.Location = new System.Drawing.Point(365, 20);
            this.LabelInt.Name = "LabelInt";
            this.LabelInt.Size = new System.Drawing.Size(51, 13);
            this.LabelInt.TabIndex = 5;
            this.LabelInt.Text = "Int value:";
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
            // LabelChooseValue
            // 
            this.LabelChooseValue.AutoSize = true;
            this.LabelChooseValue.Location = new System.Drawing.Point(183, 20);
            this.LabelChooseValue.Name = "LabelChooseValue";
            this.LabelChooseValue.Size = new System.Drawing.Size(75, 13);
            this.LabelChooseValue.TabIndex = 4;
            this.LabelChooseValue.Text = "Choose value:";
            // 
            // EnumsTextBox
            // 
            this.EnumsTextBox.Location = new System.Drawing.Point(365, 39);
            this.EnumsTextBox.Name = "EnumsTextBox";
            this.EnumsTextBox.ReadOnly = true;
            this.EnumsTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnumsTextBox.TabIndex = 2;
            // 
            // LabelChooseEnum
            // 
            this.LabelChooseEnum.AutoSize = true;
            this.LabelChooseEnum.Location = new System.Drawing.Point(13, 20);
            this.LabelChooseEnum.Name = "LabelChooseEnum";
            this.LabelChooseEnum.Size = new System.Drawing.Size(107, 13);
            this.LabelChooseEnum.TabIndex = 3;
            this.LabelChooseEnum.Text = "Choose enumeration:";
            // 
            // EnumerationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Enumeration);
            this.Name = "EnumerationControl";
            this.Size = new System.Drawing.Size(754, 218);
            this.Enumeration.ResumeLayout(false);
            this.Enumeration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Enumeration;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label LabelInt;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label LabelChooseValue;
        private System.Windows.Forms.TextBox EnumsTextBox;
        private System.Windows.Forms.Label LabelChooseEnum;
    }
}
