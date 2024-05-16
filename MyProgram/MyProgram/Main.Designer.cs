namespace MyProgram
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListBoxInstitution = new ListBox();
            groupBox1 = new GroupBox();
            ComboBoxCategory = new ComboBox();
            TextBoxRating = new TextBox();
            TextBoxAddress = new TextBox();
            TextBoxTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ButtonAdd = new Button();
            ButtonChange = new Button();
            ButtonDelete = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxInstitution
            // 
            ListBoxInstitution.FormattingEnabled = true;
            ListBoxInstitution.ItemHeight = 15;
            ListBoxInstitution.Location = new Point(12, 12);
            ListBoxInstitution.Name = "ListBoxInstitution";
            ListBoxInstitution.Size = new Size(264, 394);
            ListBoxInstitution.Sorted = true;
            ListBoxInstitution.TabIndex = 0;
            ListBoxInstitution.SelectedIndexChanged += ListBoxInstitution_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboBoxCategory);
            groupBox1.Controls.Add(TextBoxRating);
            groupBox1.Controls.Add(TextBoxAddress);
            groupBox1.Controls.Add(TextBoxTitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(282, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 165);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected institution";
            // 
            // ComboBoxCategory
            // 
            ComboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCategory.Enabled = false;
            ComboBoxCategory.FormattingEnabled = true;
            ComboBoxCategory.Location = new Point(74, 84);
            ComboBoxCategory.Name = "ComboBoxCategory";
            ComboBoxCategory.Size = new Size(140, 23);
            ComboBoxCategory.TabIndex = 7;
            // 
            // TextBoxRating
            // 
            TextBoxRating.Enabled = false;
            TextBoxRating.Location = new Point(74, 113);
            TextBoxRating.Name = "TextBoxRating";
            TextBoxRating.Size = new Size(140, 23);
            TextBoxRating.TabIndex = 6;
            TextBoxRating.TextChanged += TextBoxRating_TextChanged;
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.Enabled = false;
            TextBoxAddress.Location = new Point(74, 55);
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(426, 23);
            TextBoxAddress.TabIndex = 5;
            TextBoxAddress.TextChanged += TextBoxAddress_TextChanged;
            // 
            // TextBoxTitle
            // 
            TextBoxTitle.Enabled = false;
            TextBoxTitle.Location = new Point(74, 26);
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new Size(426, 23);
            TextBoxTitle.TabIndex = 4;
            TextBoxTitle.TextChanged += TextBoxTitle_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 121);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Rating:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 92);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(12, 415);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 2;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonChange
            // 
            ButtonChange.Location = new Point(93, 415);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(75, 23);
            ButtonChange.TabIndex = 3;
            ButtonChange.Text = "Change";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(174, 415);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 4;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonChange);
            Controls.Add(ButtonAdd);
            Controls.Add(groupBox1);
            Controls.Add(ListBoxInstitution);
            Name = "Main";
            Text = "Form1";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxInstitution;
        private GroupBox groupBox1;
        private ComboBox ComboBoxCategory;
        private TextBox TextBoxRating;
        private TextBox TextBoxAddress;
        private TextBox TextBoxTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ButtonAdd;
        private Button ButtonChange;
        private Button ButtonDelete;
    }
}