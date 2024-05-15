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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.seasonControl1 = new Programming.View.Panels.SeasonControl();
            this.weekdayControl1 = new Programming.View.Panels.WeekdayControl();
            this.enumerationControl1 = new Programming.View.Panels.EnumerationControl();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.seasonControl1);
            this.tabPage3.Controls.Add(this.weekdayControl1);
            this.tabPage3.Controls.Add(this.enumerationControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Enums";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moviesControl1);
            this.tabPage1.Controls.Add(this.rectanglesControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rectanglesCollisionControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Rectangles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // seasonControl1
            // 
            this.seasonControl1.Location = new System.Drawing.Point(379, 229);
            this.seasonControl1.Name = "seasonControl1";
            this.seasonControl1.Size = new System.Drawing.Size(384, 148);
            this.seasonControl1.TabIndex = 11;
            // 
            // weekdayControl1
            // 
            this.weekdayControl1.Location = new System.Drawing.Point(9, 229);
            this.weekdayControl1.Name = "weekdayControl1";
            this.weekdayControl1.Size = new System.Drawing.Size(352, 147);
            this.weekdayControl1.TabIndex = 10;
            // 
            // enumerationControl1
            // 
            this.enumerationControl1.Location = new System.Drawing.Point(9, 4);
            this.enumerationControl1.Name = "enumerationControl1";
            this.enumerationControl1.Size = new System.Drawing.Size(754, 218);
            this.enumerationControl1.TabIndex = 9;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(786, 418);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(8, 7);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(372, 304);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(412, 7);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(372, 304);
            this.moviesControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationControl enumerationControl1;
        private View.Panels.SeasonControl seasonControl1;
        private View.Panels.WeekdayControl weekdayControl1;
        private View.Panels.MoviesControl moviesControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
    }
}

