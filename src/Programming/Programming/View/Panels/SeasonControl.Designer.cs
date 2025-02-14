namespace Programming.View.Panels
{
    partial class SeasonControl
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
            this.GroupBoxSeason = new System.Windows.Forms.GroupBox();
            this.ComboBoxSeason = new System.Windows.Forms.ComboBox();
            this.ButtonSeason = new System.Windows.Forms.Button();
            this.LabelChooseSeason = new System.Windows.Forms.Label();
            this.GroupBoxSeason.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSeason
            // 
            this.GroupBoxSeason.Controls.Add(this.ComboBoxSeason);
            this.GroupBoxSeason.Controls.Add(this.ButtonSeason);
            this.GroupBoxSeason.Controls.Add(this.LabelChooseSeason);
            this.GroupBoxSeason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxSeason.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxSeason.Name = "GroupBoxSeason";
            this.GroupBoxSeason.Size = new System.Drawing.Size(384, 148);
            this.GroupBoxSeason.TabIndex = 9;
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
            this.ButtonSeason.Text = "Go!";
            this.ButtonSeason.UseVisualStyleBackColor = true;
            this.ButtonSeason.Click += new System.EventHandler(this.ButtonSeason_Click);
            // 
            // LabelChooseSeason
            // 
            this.LabelChooseSeason.AutoSize = true;
            this.LabelChooseSeason.Location = new System.Drawing.Point(17, 30);
            this.LabelChooseSeason.Name = "LabelChooseSeason";
            this.LabelChooseSeason.Size = new System.Drawing.Size(83, 13);
            this.LabelChooseSeason.TabIndex = 0;
            this.LabelChooseSeason.Text = "Choose season:";
            // 
            // SeasonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxSeason);
            this.Name = "SeasonControl";
            this.Size = new System.Drawing.Size(384, 148);
            this.GroupBoxSeason.ResumeLayout(false);
            this.GroupBoxSeason.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSeason;
        private System.Windows.Forms.ComboBox ComboBoxSeason;
        private System.Windows.Forms.Button ButtonSeason;
        private System.Windows.Forms.Label LabelChooseSeason;
    }
}
