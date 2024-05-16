namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.TextBoxXRectangle = new System.Windows.Forms.TextBox();
            this.TextBoxYRectangle = new System.Windows.Forms.TextBox();
            this.TextBoxWidthRectangle = new System.Windows.Forms.TextBox();
            this.TextBoxHeightRectangle = new System.Windows.Forms.TextBox();
            this.TextBoxIDRectangle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ListBoxRectangles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRectangle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TextBoxXRectangle
            // 
            this.TextBoxXRectangle.Location = new System.Drawing.Point(63, 246);
            this.TextBoxXRectangle.Name = "TextBoxXRectangle";
            this.TextBoxXRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxXRectangle.TabIndex = 31;
            this.TextBoxXRectangle.Click += new System.EventHandler(this.ListBoxRectangles_SelectedIndexChanged);
            this.TextBoxXRectangle.TextChanged += new System.EventHandler(this.TextBoxXRectangle_TextChanged);
            // 
            // TextBoxYRectangle
            // 
            this.TextBoxYRectangle.Location = new System.Drawing.Point(63, 272);
            this.TextBoxYRectangle.Name = "TextBoxYRectangle";
            this.TextBoxYRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxYRectangle.TabIndex = 30;
            this.TextBoxYRectangle.TextChanged += new System.EventHandler(this.TextBoxYRectangle_TextChanged);
            // 
            // TextBoxWidthRectangle
            // 
            this.TextBoxWidthRectangle.Location = new System.Drawing.Point(63, 298);
            this.TextBoxWidthRectangle.Name = "TextBoxWidthRectangle";
            this.TextBoxWidthRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidthRectangle.TabIndex = 29;
            this.TextBoxWidthRectangle.TextChanged += new System.EventHandler(this.TextBoxWidthRectangle_TextChanged);
            // 
            // TextBoxHeightRectangle
            // 
            this.TextBoxHeightRectangle.Location = new System.Drawing.Point(63, 324);
            this.TextBoxHeightRectangle.Name = "TextBoxHeightRectangle";
            this.TextBoxHeightRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeightRectangle.TabIndex = 28;
            this.TextBoxHeightRectangle.TextChanged += new System.EventHandler(this.TextBoxHeightRectangle_TextChanged);
            // 
            // TextBoxIDRectangle
            // 
            this.TextBoxIDRectangle.Location = new System.Drawing.Point(63, 220);
            this.TextBoxIDRectangle.Name = "TextBoxIDRectangle";
            this.TextBoxIDRectangle.ReadOnly = true;
            this.TextBoxIDRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIDRectangle.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Selected Rectangle:";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(88, 162);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 20;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(6, 162);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 19;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ListBoxRectangles
            // 
            this.ListBoxRectangles.FormattingEnabled = true;
            this.ListBoxRectangles.Location = new System.Drawing.Point(6, 21);
            this.ListBoxRectangles.Name = "ListBoxRectangles";
            this.ListBoxRectangles.Size = new System.Drawing.Size(190, 134);
            this.ListBoxRectangles.TabIndex = 18;
            this.ListBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxRectangles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rectangles:";
            // 
            // PanelRectangle
            // 
            this.PanelRectangle.BackColor = System.Drawing.SystemColors.Window;
            this.PanelRectangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRectangle.Location = new System.Drawing.Point(202, 3);
            this.PanelRectangle.Name = "PanelRectangle";
            this.PanelRectangle.Size = new System.Drawing.Size(576, 410);
            this.PanelRectangle.TabIndex = 16;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxXRectangle);
            this.Controls.Add(this.TextBoxYRectangle);
            this.Controls.Add(this.TextBoxWidthRectangle);
            this.Controls.Add(this.TextBoxHeightRectangle);
            this.Controls.Add(this.TextBoxIDRectangle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ListBoxRectangles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelRectangle);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(781, 417);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxXRectangle;
        private System.Windows.Forms.TextBox TextBoxYRectangle;
        private System.Windows.Forms.TextBox TextBoxWidthRectangle;
        private System.Windows.Forms.TextBox TextBoxHeightRectangle;
        private System.Windows.Forms.TextBox TextBoxIDRectangle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ListBox ListBoxRectangles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelRectangle;
    }
}
