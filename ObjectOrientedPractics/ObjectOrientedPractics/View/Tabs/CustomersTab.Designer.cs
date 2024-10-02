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
            this.SelecetedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.SelecetedCustomerGroupBox.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(2, 32);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(231, 420);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            this.CustomersListBox.DoubleClick += new System.EventHandler(this.CustomersListBox_DoubleClick);
            // 
            // SelecetedCustomerGroupBox
            // 
            this.SelecetedCustomerGroupBox.Controls.Add(this.AddressTextBox);
            this.SelecetedCustomerGroupBox.Controls.Add(this.label5);
            this.SelecetedCustomerGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelecetedCustomerGroupBox.Controls.Add(this.label4);
            this.SelecetedCustomerGroupBox.Controls.Add(this.IDTextBox);
            this.SelecetedCustomerGroupBox.Controls.Add(this.label3);
            this.SelecetedCustomerGroupBox.Controls.Add(this.label2);
            this.SelecetedCustomerGroupBox.Location = new System.Drawing.Point(245, 0);
            this.SelecetedCustomerGroupBox.Name = "SelecetedCustomerGroupBox";
            this.SelecetedCustomerGroupBox.Size = new System.Drawing.Size(458, 199);
            this.SelecetedCustomerGroupBox.TabIndex = 2;
            this.SelecetedCustomerGroupBox.TabStop = false;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(69, 96);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(386, 96);
            this.AddressTextBox.TabIndex = 6;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(69, 70);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(119, 20);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Name:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.IDTextBox.Location = new System.Drawing.Point(69, 44);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(119, 20);
            this.IDTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Customer";
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.RemoveButton);
            this.CustomersGroupBox.Controls.Add(this.AddButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Controls.Add(this.label1);
            this.CustomersGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CustomersGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(239, 502);
            this.CustomersGroupBox.TabIndex = 3;
            this.CustomersGroupBox.TabStop = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(104, 462);
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
            this.AddButton.Location = new System.Drawing.Point(6, 462);
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
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Location = new System.Drawing.Point(245, 198);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(455, 301);
            this.CustomerPanel.TabIndex = 4;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.SelecetedCustomerGroupBox);
            this.Controls.Add(this.CustomersGroupBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(703, 502);
            this.SelecetedCustomerGroupBox.ResumeLayout(false);
            this.SelecetedCustomerGroupBox.PerformLayout();
            this.CustomersGroupBox.ResumeLayout(false);
            this.CustomersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.GroupBox SelecetedCustomerGroupBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CustomerPanel;
    }
}
