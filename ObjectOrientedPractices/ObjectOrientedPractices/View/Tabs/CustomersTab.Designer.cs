namespace ObjectOrientedPractices.View.Tabs
{
    partial class CustomersTab
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
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.addressControl1 = new ObjectOrientedPractices.View.Controls.AddressControl();
            this.PriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(7, 25);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(231, 381);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            this.CustomersListBox.DoubleClick += new System.EventHandler(this.CustomersListBox_DoubleClick);
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(240, 0);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(0, 0);
            this.SelectedCustomerGroupBox.TabIndex = 5;
            this.SelectedCustomerGroupBox.TabStop = false;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(313, 64);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(119, 20);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Name:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.IDTextBox.Location = new System.Drawing.Point(313, 38);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(119, 20);
            this.IDTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Customer";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(109, 428);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(92, 37);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(11, 428);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Location = new System.Drawing.Point(244, 186);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(0, 0);
            this.CustomerPanel.TabIndex = 7;
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(239, 113);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(458, 142);
            this.addressControl1.TabIndex = 8;
            // 
            // PriorityCheckBox
            // 
            this.PriorityCheckBox.AutoSize = true;
            this.PriorityCheckBox.Location = new System.Drawing.Point(313, 90);
            this.PriorityCheckBox.Name = "PriorityCheckBox";
            this.PriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.PriorityCheckBox.TabIndex = 9;
            this.PriorityCheckBox.Text = "Is Priority";
            this.PriorityCheckBox.UseVisualStyleBackColor = true;
            this.PriorityCheckBox.CheckedChanged += new System.EventHandler(this.PriorityCheckBox_CheckedChanged);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityCheckBox);
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedCustomerGroupBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(700, 475);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.GroupBox SelectedCustomerGroupBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CustomerPanel;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.CheckBox PriorityCheckBox;
    }
}
