namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            this.GroupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.ButtonFindRectangles = new System.Windows.Forms.Button();
            this.LabelColor = new System.Windows.Forms.Label();
            this.TextBoxColor = new System.Windows.Forms.TextBox();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.LabelLength = new System.Windows.Forms.Label();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.ListBoxRectangles = new System.Windows.Forms.ListBox();
            this.GroupBoxRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxRectangles
            // 
            this.GroupBoxRectangles.Controls.Add(this.LabelId);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxId);
            this.GroupBoxRectangles.Controls.Add(this.YLabel);
            this.GroupBoxRectangles.Controls.Add(this.YTextBox);
            this.GroupBoxRectangles.Controls.Add(this.XLabel);
            this.GroupBoxRectangles.Controls.Add(this.XTextBox);
            this.GroupBoxRectangles.Controls.Add(this.ButtonFindRectangles);
            this.GroupBoxRectangles.Controls.Add(this.LabelColor);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxColor);
            this.GroupBoxRectangles.Controls.Add(this.LabelWidth);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxWidth);
            this.GroupBoxRectangles.Controls.Add(this.LabelLength);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxHeight);
            this.GroupBoxRectangles.Controls.Add(this.ListBoxRectangles);
            this.GroupBoxRectangles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxRectangles.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxRectangles.Name = "GroupBoxRectangles";
            this.GroupBoxRectangles.Size = new System.Drawing.Size(372, 304);
            this.GroupBoxRectangles.TabIndex = 1;
            this.GroupBoxRectangles.TabStop = false;
            this.GroupBoxRectangles.Text = "Rectangles";
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(265, 111);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(19, 13);
            this.LabelId.TabIndex = 12;
            this.LabelId.Text = "Id:";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(268, 127);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(57, 20);
            this.TextBoxId.TabIndex = 11;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(265, 64);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 10;
            this.YLabel.Text = "Y:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(268, 80);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(57, 20);
            this.YTextBox.TabIndex = 9;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(265, 20);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 8;
            this.XLabel.Text = "X:";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(268, 36);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(57, 20);
            this.XTextBox.TabIndex = 7;
            // 
            // ButtonFindRectangles
            // 
            this.ButtonFindRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ButtonFindRectangles.Location = new System.Drawing.Point(7, 229);
            this.ButtonFindRectangles.Name = "ButtonFindRectangles";
            this.ButtonFindRectangles.Size = new System.Drawing.Size(352, 61);
            this.ButtonFindRectangles.TabIndex = 1;
            this.ButtonFindRectangles.Text = "Find";
            this.ButtonFindRectangles.UseVisualStyleBackColor = true;
            this.ButtonFindRectangles.Click += new System.EventHandler(this.ButtonFindRectangles_Click);
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.Location = new System.Drawing.Point(159, 111);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(34, 13);
            this.LabelColor.TabIndex = 6;
            this.LabelColor.Text = "Color:";
            // 
            // TextBoxColor
            // 
            this.TextBoxColor.Location = new System.Drawing.Point(162, 127);
            this.TextBoxColor.Name = "TextBoxColor";
            this.TextBoxColor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxColor.TabIndex = 5;
            this.TextBoxColor.TextChanged += new System.EventHandler(this.TextBoxColor_TextChanged);
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Location = new System.Drawing.Point(159, 64);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(38, 13);
            this.LabelWidth.TabIndex = 4;
            this.LabelWidth.Text = "Width:";
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Location = new System.Drawing.Point(162, 80);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidth.TabIndex = 3;
            this.TextBoxWidth.TextChanged += new System.EventHandler(this.TextBoxWidth_TextChanged);
            // 
            // LabelLength
            // 
            this.LabelLength.AutoSize = true;
            this.LabelLength.Location = new System.Drawing.Point(159, 20);
            this.LabelLength.Name = "LabelLength";
            this.LabelLength.Size = new System.Drawing.Size(43, 13);
            this.LabelLength.TabIndex = 2;
            this.LabelLength.Text = "Length:";
            // 
            // TextBoxLength
            // 
            this.TextBoxHeight.Location = new System.Drawing.Point(162, 36);
            this.TextBoxHeight.Name = "TextBoxLength";
            this.TextBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight.TabIndex = 1;
            this.TextBoxHeight.TextChanged += new System.EventHandler(this.TextBoxHeight_TextChanged);
            // 
            // ListBoxRectangles
            // 
            this.ListBoxRectangles.FormattingEnabled = true;
            this.ListBoxRectangles.Location = new System.Drawing.Point(7, 20);
            this.ListBoxRectangles.Name = "ListBoxRectangles";
            this.ListBoxRectangles.Size = new System.Drawing.Size(146, 173);
            this.ListBoxRectangles.TabIndex = 0;
            this.ListBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxRectangles_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxRectangles);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(372, 304);
            this.GroupBoxRectangles.ResumeLayout(false);
            this.GroupBoxRectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxRectangles;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Button ButtonFindRectangles;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.TextBox TextBoxColor;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.Label LabelLength;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.ListBox ListBoxRectangles;
    }
}
