namespace Programming.View.Panels
{
    partial class MoviesControl
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
            this.GroupBoMovie = new System.Windows.Forms.GroupBox();
            this.LabelRating = new System.Windows.Forms.Label();
            this.TextBoxRating = new System.Windows.Forms.TextBox();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.ButtonFindMovies = new System.Windows.Forms.Button();
            this.LabelYearRelease = new System.Windows.Forms.Label();
            this.TextBoxYearRelease = new System.Windows.Forms.TextBox();
            this.LabelDurationMinutes = new System.Windows.Forms.Label();
            this.TextBoxDurationMinutes = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.ListBoxMovies = new System.Windows.Forms.ListBox();
            this.GroupBoMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoMovie
            // 
            this.GroupBoMovie.Controls.Add(this.LabelRating);
            this.GroupBoMovie.Controls.Add(this.TextBoxRating);
            this.GroupBoMovie.Controls.Add(this.LabelGenre);
            this.GroupBoMovie.Controls.Add(this.TextBoxGenre);
            this.GroupBoMovie.Controls.Add(this.ButtonFindMovies);
            this.GroupBoMovie.Controls.Add(this.LabelYearRelease);
            this.GroupBoMovie.Controls.Add(this.TextBoxYearRelease);
            this.GroupBoMovie.Controls.Add(this.LabelDurationMinutes);
            this.GroupBoMovie.Controls.Add(this.TextBoxDurationMinutes);
            this.GroupBoMovie.Controls.Add(this.LabelTitle);
            this.GroupBoMovie.Controls.Add(this.TextBoxTitle);
            this.GroupBoMovie.Controls.Add(this.ListBoxMovies);
            this.GroupBoMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoMovie.Location = new System.Drawing.Point(0, 0);
            this.GroupBoMovie.Name = "GroupBoMovie";
            this.GroupBoMovie.Size = new System.Drawing.Size(372, 304);
            this.GroupBoMovie.TabIndex = 2;
            this.GroupBoMovie.TabStop = false;
            this.GroupBoMovie.Text = "Movies";
            // 
            // LabelRating
            // 
            this.LabelRating.AutoSize = true;
            this.LabelRating.Location = new System.Drawing.Point(159, 174);
            this.LabelRating.Name = "LabelRating";
            this.LabelRating.Size = new System.Drawing.Size(41, 13);
            this.LabelRating.TabIndex = 10;
            this.LabelRating.Text = "Rating:";
            // 
            // TextBoxRating
            // 
            this.TextBoxRating.Location = new System.Drawing.Point(162, 190);
            this.TextBoxRating.Name = "TextBoxRating";
            this.TextBoxRating.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRating.TabIndex = 9;
            this.TextBoxRating.TextChanged += new System.EventHandler(this.TextBoxRating_TextChanged);
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Location = new System.Drawing.Point(159, 134);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(39, 13);
            this.LabelGenre.TabIndex = 8;
            this.LabelGenre.Text = "Genre:";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Location = new System.Drawing.Point(162, 150);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.TextBoxGenre.TabIndex = 7;
            this.TextBoxGenre.TextChanged += new System.EventHandler(this.TextBoxGenre_TextChanged);
            // 
            // ButtonFindMovies
            // 
            this.ButtonFindMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ButtonFindMovies.Location = new System.Drawing.Point(7, 229);
            this.ButtonFindMovies.Name = "ButtonFindMovies";
            this.ButtonFindMovies.Size = new System.Drawing.Size(352, 61);
            this.ButtonFindMovies.TabIndex = 1;
            this.ButtonFindMovies.Text = "Find";
            this.ButtonFindMovies.UseVisualStyleBackColor = true;
            this.ButtonFindMovies.Click += new System.EventHandler(this.ButtonFindMovies_Click);
            // 
            // LabelYearRelease
            // 
            this.LabelYearRelease.AutoSize = true;
            this.LabelYearRelease.Location = new System.Drawing.Point(159, 95);
            this.LabelYearRelease.Name = "LabelYearRelease";
            this.LabelYearRelease.Size = new System.Drawing.Size(106, 13);
            this.LabelYearRelease.TabIndex = 6;
            this.LabelYearRelease.Text = "Year of manufacture:";
            // 
            // TextBoxYearRelease
            // 
            this.TextBoxYearRelease.Location = new System.Drawing.Point(162, 111);
            this.TextBoxYearRelease.Name = "TextBoxYearRelease";
            this.TextBoxYearRelease.Size = new System.Drawing.Size(100, 20);
            this.TextBoxYearRelease.TabIndex = 5;
            this.TextBoxYearRelease.TextChanged += new System.EventHandler(this.TextBoxYearRelease_TextChanged);
            // 
            // LabelDurationMinutes
            // 
            this.LabelDurationMinutes.AutoSize = true;
            this.LabelDurationMinutes.Location = new System.Drawing.Point(159, 59);
            this.LabelDurationMinutes.Name = "LabelDurationMinutes";
            this.LabelDurationMinutes.Size = new System.Drawing.Size(100, 13);
            this.LabelDurationMinutes.TabIndex = 4;
            this.LabelDurationMinutes.Text = "Duration in minutes:";
            // 
            // TextBoxDurationMinutes
            // 
            this.TextBoxDurationMinutes.Location = new System.Drawing.Point(162, 75);
            this.TextBoxDurationMinutes.Name = "TextBoxDurationMinutes";
            this.TextBoxDurationMinutes.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDurationMinutes.TabIndex = 3;
            this.TextBoxDurationMinutes.TextChanged += new System.EventHandler(this.TextBoxDurationMinutes_TextChanged);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(159, 20);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(30, 13);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Title:";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(162, 36);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTitle.TabIndex = 1;
            this.TextBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // ListBoxMovies
            // 
            this.ListBoxMovies.FormattingEnabled = true;
            this.ListBoxMovies.Location = new System.Drawing.Point(7, 20);
            this.ListBoxMovies.Name = "ListBoxMovies";
            this.ListBoxMovies.Size = new System.Drawing.Size(146, 173);
            this.ListBoxMovies.TabIndex = 0;
            this.ListBoxMovies.SelectedIndexChanged += new System.EventHandler(this.ListBoxMovies_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoMovie);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(372, 304);
            this.GroupBoMovie.ResumeLayout(false);
            this.GroupBoMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoMovie;
        private System.Windows.Forms.Label LabelRating;
        private System.Windows.Forms.TextBox TextBoxRating;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.Button ButtonFindMovies;
        private System.Windows.Forms.Label LabelYearRelease;
        private System.Windows.Forms.TextBox TextBoxYearRelease;
        private System.Windows.Forms.Label LabelDurationMinutes;
        private System.Windows.Forms.TextBox TextBoxDurationMinutes;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.ListBox ListBoxMovies;
    }
}
