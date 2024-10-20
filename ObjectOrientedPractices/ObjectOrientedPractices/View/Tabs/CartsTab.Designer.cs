namespace ObjectOrientedPractices.View.Tabs
{
    partial class CartsTab
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
            this.AddCartButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCartButton
            // 
            this.AddCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCartButton.Location = new System.Drawing.Point(7, 424);
            this.AddCartButton.Name = "AddCartButton";
            this.AddCartButton.Size = new System.Drawing.Size(92, 38);
            this.AddCartButton.TabIndex = 4;
            this.AddCartButton.Text = "Add To Cart";
            this.AddCartButton.UseVisualStyleBackColor = true;
            this.AddCartButton.Click += new System.EventHandler(this.AddCartButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 21);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(231, 381);
            this.ItemsListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(316, 21);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(381, 21);
            this.CustomerComboBox.TabIndex = 16;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cart:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(247, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(644, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount:";
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(247, 259);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(92, 38);
            this.CreateOrderButton.TabIndex = 19;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(507, 259);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(92, 38);
            this.RemoveItemButton.TabIndex = 20;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(605, 259);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(92, 38);
            this.ClearCartButton.TabIndex = 21;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(247, 78);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(450, 121);
            this.CartListBox.TabIndex = 22;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountTextBox.Location = new System.Drawing.Point(588, 224);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(109, 29);
            this.AmountTextBox.TabIndex = 23;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCartButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.label1);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(700, 475);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCartButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}
