namespace ObjectOrientedPractices.View.Tabs
{
    partial class DiscountsTab
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
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelProductAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelDiscountAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(17, 48);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(111, 45);
            this.ButtonCalculate.TabIndex = 0;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Location = new System.Drawing.Point(134, 48);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(111, 45);
            this.ButtonApply.TabIndex = 1;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(251, 48);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(111, 45);
            this.ButtonUpdate.TabIndex = 2;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.Location = new System.Drawing.Point(14, 30);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(37, 13);
            this.LabelInfo.TabIndex = 3;
            this.LabelInfo.Text = "Info: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(395, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Amount:";
            // 
            // LabelProductAmount
            // 
            this.LabelProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductAmount.Location = new System.Drawing.Point(398, 47);
            this.LabelProductAmount.Name = "LabelProductAmount";
            this.LabelProductAmount.Size = new System.Drawing.Size(104, 23);
            this.LabelProductAmount.TabIndex = 5;
            this.LabelProductAmount.Text = "0,00";
            this.LabelProductAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(395, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discount Amount:";
            // 
            // LabelDiscountAmount
            // 
            this.LabelDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDiscountAmount.Location = new System.Drawing.Point(398, 93);
            this.LabelDiscountAmount.Name = "LabelDiscountAmount";
            this.LabelDiscountAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelDiscountAmount.Size = new System.Drawing.Size(104, 20);
            this.LabelDiscountAmount.TabIndex = 7;
            this.LabelDiscountAmount.Text = "0";
            this.LabelDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelDiscountAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelProductAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonCalculate);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(515, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelProductAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelDiscountAmount;
    }
}
