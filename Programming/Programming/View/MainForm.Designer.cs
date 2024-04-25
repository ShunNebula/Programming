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
            this.GroupBoxSeason = new System.Windows.Forms.GroupBox();
            this.ComboBoxSeason = new System.Windows.Forms.ComboBox();
            this.ButtonSeason = new System.Windows.Forms.Button();
            this.LabelChooseSeason = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonParse = new System.Windows.Forms.Button();
            this.TextBoxParsing = new System.Windows.Forms.TextBox();
            this.LabelParsing2 = new System.Windows.Forms.Label();
            this.LabelParsing1 = new System.Windows.Forms.Label();
            this.Enumeration = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.LabelInt = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.LabelChooseValue = new System.Windows.Forms.Label();
            this.EnumsTextBox = new System.Windows.Forms.TextBox();
            this.LabelChooseEnum = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.TextBoxLength = new System.Windows.Forms.TextBox();
            this.ListBoxRectangles = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.ListBoxRectangles1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRectangle = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.GroupBoxSeason.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Enumeration.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GroupBoMovie.SuspendLayout();
            this.GroupBoxRectangles.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.GroupBoxSeason);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.Enumeration);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Enums";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeason
            // 
            this.GroupBoxSeason.Controls.Add(this.ComboBoxSeason);
            this.GroupBoxSeason.Controls.Add(this.ButtonSeason);
            this.GroupBoxSeason.Controls.Add(this.LabelChooseSeason);
            this.GroupBoxSeason.Location = new System.Drawing.Point(376, 221);
            this.GroupBoxSeason.Name = "GroupBoxSeason";
            this.GroupBoxSeason.Size = new System.Drawing.Size(377, 140);
            this.GroupBoxSeason.TabIndex = 8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonParse);
            this.groupBox1.Controls.Add(this.TextBoxParsing);
            this.groupBox1.Controls.Add(this.LabelParsing2);
            this.groupBox1.Controls.Add(this.LabelParsing1);
            this.groupBox1.Location = new System.Drawing.Point(8, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weekday Parsing";
            // 
            // ButtonParse
            // 
            this.ButtonParse.Location = new System.Drawing.Point(186, 44);
            this.ButtonParse.Name = "ButtonParse";
            this.ButtonParse.Size = new System.Drawing.Size(75, 23);
            this.ButtonParse.TabIndex = 3;
            this.ButtonParse.Text = "Parse";
            this.ButtonParse.UseVisualStyleBackColor = true;
            this.ButtonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // TextBoxParsing
            // 
            this.TextBoxParsing.Location = new System.Drawing.Point(19, 47);
            this.TextBoxParsing.Name = "TextBoxParsing";
            this.TextBoxParsing.Size = new System.Drawing.Size(153, 20);
            this.TextBoxParsing.TabIndex = 2;
            // 
            // LabelParsing2
            // 
            this.LabelParsing2.AutoSize = true;
            this.LabelParsing2.Location = new System.Drawing.Point(16, 83);
            this.LabelParsing2.Name = "LabelParsing2";
            this.LabelParsing2.Size = new System.Drawing.Size(13, 13);
            this.LabelParsing2.TabIndex = 1;
            this.LabelParsing2.Text = "0";
            // 
            // LabelParsing1
            // 
            this.LabelParsing1.AutoSize = true;
            this.LabelParsing1.Location = new System.Drawing.Point(16, 30);
            this.LabelParsing1.Name = "LabelParsing1";
            this.LabelParsing1.Size = new System.Drawing.Size(112, 13);
            this.LabelParsing1.TabIndex = 0;
            this.LabelParsing1.Text = "Type value for parsing";
            // 
            // Enumeration
            // 
            this.Enumeration.Controls.Add(this.ValuesListBox);
            this.Enumeration.Controls.Add(this.LabelInt);
            this.Enumeration.Controls.Add(this.EnumsListBox);
            this.Enumeration.Controls.Add(this.LabelChooseValue);
            this.Enumeration.Controls.Add(this.EnumsTextBox);
            this.Enumeration.Controls.Add(this.LabelChooseEnum);
            this.Enumeration.Location = new System.Drawing.Point(8, 3);
            this.Enumeration.Name = "Enumeration";
            this.Enumeration.Size = new System.Drawing.Size(745, 211);
            this.Enumeration.TabIndex = 6;
            this.Enumeration.TabStop = false;
            this.Enumeration.Text = "Enumeration";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(183, 39);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 95);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // LabelInt
            // 
            this.LabelInt.AutoSize = true;
            this.LabelInt.Location = new System.Drawing.Point(365, 20);
            this.LabelInt.Name = "LabelInt";
            this.LabelInt.Size = new System.Drawing.Size(51, 13);
            this.LabelInt.TabIndex = 5;
            this.LabelInt.Text = "Int value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 39);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 95);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // LabelChooseValue
            // 
            this.LabelChooseValue.AutoSize = true;
            this.LabelChooseValue.Location = new System.Drawing.Point(183, 20);
            this.LabelChooseValue.Name = "LabelChooseValue";
            this.LabelChooseValue.Size = new System.Drawing.Size(75, 13);
            this.LabelChooseValue.TabIndex = 4;
            this.LabelChooseValue.Text = "Choose value:";
            // 
            // EnumsTextBox
            // 
            this.EnumsTextBox.Location = new System.Drawing.Point(365, 39);
            this.EnumsTextBox.Name = "EnumsTextBox";
            this.EnumsTextBox.ReadOnly = true;
            this.EnumsTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnumsTextBox.TabIndex = 2;
            // 
            // LabelChooseEnum
            // 
            this.LabelChooseEnum.AutoSize = true;
            this.LabelChooseEnum.Location = new System.Drawing.Point(13, 20);
            this.LabelChooseEnum.Name = "LabelChooseEnum";
            this.LabelChooseEnum.Size = new System.Drawing.Size(107, 13);
            this.LabelChooseEnum.TabIndex = 3;
            this.LabelChooseEnum.Text = "Choose enumeration:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GroupBoMovie);
            this.tabPage1.Controls.Add(this.GroupBoxRectangles);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.GroupBoMovie.Location = new System.Drawing.Point(409, 7);
            this.GroupBoMovie.Name = "GroupBoMovie";
            this.GroupBoMovie.Size = new System.Drawing.Size(365, 296);
            this.GroupBoMovie.TabIndex = 1;
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
            this.GroupBoxRectangles.Controls.Add(this.TextBoxLength);
            this.GroupBoxRectangles.Controls.Add(this.ListBoxRectangles);
            this.GroupBoxRectangles.Location = new System.Drawing.Point(9, 7);
            this.GroupBoxRectangles.Name = "GroupBoxRectangles";
            this.GroupBoxRectangles.Size = new System.Drawing.Size(365, 296);
            this.GroupBoxRectangles.TabIndex = 0;
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
            this.TextBoxLength.Location = new System.Drawing.Point(162, 36);
            this.TextBoxLength.Name = "TextBoxLength";
            this.TextBoxLength.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLength.TabIndex = 1;
            this.TextBoxLength.TextChanged += new System.EventHandler(this.TextBoxLength_TextChanged);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TextBoxXRectangle);
            this.tabPage2.Controls.Add(this.TextBoxYRectangle);
            this.tabPage2.Controls.Add(this.TextBoxWidthRectangle);
            this.tabPage2.Controls.Add(this.TextBoxHeightRectangle);
            this.tabPage2.Controls.Add(this.TextBoxIDRectangle);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ButtonDelete);
            this.tabPage2.Controls.Add(this.ButtonAdd);
            this.tabPage2.Controls.Add(this.ListBoxRectangles1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.PanelRectangle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Rectangles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBoxXRectangle
            // 
            this.TextBoxXRectangle.Location = new System.Drawing.Point(69, 249);
            this.TextBoxXRectangle.Name = "TextBoxXRectangle";
            this.TextBoxXRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxXRectangle.TabIndex = 15;
            this.TextBoxXRectangle.TextChanged += new System.EventHandler(this.TextBoxXRectangle_TextChanged);
            // 
            // TextBoxYRectangle
            // 
            this.TextBoxYRectangle.Location = new System.Drawing.Point(69, 275);
            this.TextBoxYRectangle.Name = "TextBoxYRectangle";
            this.TextBoxYRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxYRectangle.TabIndex = 14;
            this.TextBoxYRectangle.TextChanged += new System.EventHandler(this.TextBoxYRectangle_TextChanged);
            // 
            // TextBoxWidthRectangle
            // 
            this.TextBoxWidthRectangle.Location = new System.Drawing.Point(69, 301);
            this.TextBoxWidthRectangle.Name = "TextBoxWidthRectangle";
            this.TextBoxWidthRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidthRectangle.TabIndex = 13;
            this.TextBoxWidthRectangle.TextChanged += new System.EventHandler(this.TextBoxWidthRectangle_TextChanged);
            // 
            // TextBoxHeightRectangle
            // 
            this.TextBoxHeightRectangle.Location = new System.Drawing.Point(69, 327);
            this.TextBoxHeightRectangle.Name = "TextBoxHeightRectangle";
            this.TextBoxHeightRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeightRectangle.TabIndex = 12;
            this.TextBoxHeightRectangle.TextChanged += new System.EventHandler(this.TextBoxHeightRectangle_TextChanged);
            // 
            // TextBoxIDRectangle
            // 
            this.TextBoxIDRectangle.Location = new System.Drawing.Point(69, 223);
            this.TextBoxIDRectangle.Name = "TextBoxIDRectangle";
            this.TextBoxIDRectangle.ReadOnly = true;
            this.TextBoxIDRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIDRectangle.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selected Rectangle:";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(94, 165);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 165);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ListBoxRectangles1
            // 
            this.ListBoxRectangles1.FormattingEnabled = true;
            this.ListBoxRectangles1.Location = new System.Drawing.Point(12, 24);
            this.ListBoxRectangles1.Name = "ListBoxRectangles1";
            this.ListBoxRectangles1.Size = new System.Drawing.Size(190, 134);
            this.ListBoxRectangles1.TabIndex = 2;
            this.ListBoxRectangles1.SelectedIndexChanged += new System.EventHandler(this.ListBoxRectangles1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rectangles:";
            // 
            // PanelRectangle
            // 
            this.PanelRectangle.BackColor = System.Drawing.SystemColors.Window;
            this.PanelRectangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRectangle.Location = new System.Drawing.Point(208, 6);
            this.PanelRectangle.Name = "PanelRectangle";
            this.PanelRectangle.Size = new System.Drawing.Size(576, 410);
            this.PanelRectangle.TabIndex = 0;
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
            this.GroupBoxSeason.ResumeLayout(false);
            this.GroupBoxSeason.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Enumeration.ResumeLayout(false);
            this.Enumeration.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.GroupBoMovie.ResumeLayout(false);
            this.GroupBoMovie.PerformLayout();
            this.GroupBoxRectangles.ResumeLayout(false);
            this.GroupBoxRectangles.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox EnumsTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label LabelInt;
        private System.Windows.Forms.Label LabelChooseValue;
        private System.Windows.Forms.Label LabelChooseEnum;
        private System.Windows.Forms.GroupBox Enumeration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonParse;
        private System.Windows.Forms.TextBox TextBoxParsing;
        private System.Windows.Forms.Label LabelParsing2;
        private System.Windows.Forms.Label LabelParsing1;
        private System.Windows.Forms.GroupBox GroupBoxSeason;
        private System.Windows.Forms.ComboBox ComboBoxSeason;
        private System.Windows.Forms.Button ButtonSeason;
        private System.Windows.Forms.Label LabelChooseSeason;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox GroupBoxRectangles;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.TextBox TextBoxColor;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.Label LabelLength;
        private System.Windows.Forms.TextBox TextBoxLength;
        private System.Windows.Forms.ListBox ListBoxRectangles;
        private System.Windows.Forms.Button ButtonFindRectangles;
        private System.Windows.Forms.GroupBox GroupBoMovie;
        private System.Windows.Forms.Button ButtonFindMovies;
        private System.Windows.Forms.Label LabelYearRelease;
        private System.Windows.Forms.TextBox TextBoxYearRelease;
        private System.Windows.Forms.Label LabelDurationMinutes;
        private System.Windows.Forms.TextBox TextBoxDurationMinutes;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.ListBox ListBoxMovies;
        private System.Windows.Forms.Label LabelRating;
        private System.Windows.Forms.TextBox TextBoxRating;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelRectangle;
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
        private System.Windows.Forms.ListBox ListBoxRectangles1;
    }
}

