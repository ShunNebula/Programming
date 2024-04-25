using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Programming
{
    public partial class MainForm : Form
    {
        private static Type[] _enums = new Type[]
        {
            typeof(ColorList),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(Weekday),
        };

        private static MyRectangle[] _rectangles = null;
        private static MyRectangle _currentRectangle = null;
        private static MyMovie[] _movies = null;
        private static MyMovie _currentMovie = null;
        private static List<MyRectangle> _rectangleR = new List<MyRectangle>();
        private static MyRectangle _currentRectangleR = null;
        private static List<Panel> _rectanglePanels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();

            this.EnumsListBox.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.EnumsListBox.SelectedIndex = 0;
            this.ComboBoxSeason.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());

            _rectangles = GetRandomRectangles(5);
            InitListBoxRectangles(5);

            _movies = GetRandomMovies(5);
            InitListBoxMovies(5);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ValuesListBox.Items.Clear();
            Type selected = _enums[this.EnumsListBox.SelectedIndex];
            this.ValuesListBox.Items.AddRange(Enum.GetValues(selected).Cast<object>().ToArray());
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EnumsTextBox.Text = ((int)this.ValuesListBox.SelectedItem).ToString();
        }

        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<Weekday>(TextBoxParsing.Text, out Weekday result)  && !int.TryParse(TextBoxParsing.Text, out int i))
            {
                LabelParsing2.Text = $"«Это день недели ({result} = {(int)result})»";
            }
            else
            {
                LabelParsing2.Text = "«Нет такого дня недели»";
            }
        }

        private void ButtonSeason_Click(object sender, EventArgs e)
        {
            switch (ComboBoxSeason.SelectedItem)
            {
                case Season.Spring:
                    GroupBoxSeason.BackColor = Color.FromArgb(48, 213, 200);
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    GroupBoxSeason.BackColor = Color.FromArgb(255, 166, 97);
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }

        private MyRectangle[] GetRandomRectangles(int size)
        {
            MyRectangle[] myRectangles = new MyRectangle[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++) 
            {
                myRectangles[i] = new MyRectangle();
                myRectangles[i].Width = ran.Next(10, 200);
                myRectangles[i].Height = ran.Next(10, 200);
                myRectangles[i].Center = new Point2D(ran.Next(0, PanelRectangle.Width), ran.Next(0, PanelRectangle.Height));
            }

            return myRectangles;
        }

        private void InitListBoxRectangles(int count)
        {
            for (int i = 0;i < count;i++) 
            {
                ListBoxRectangles.Items.Add($"Rectangle {i+1}");
            }
        }

        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[ListBoxRectangles.SelectedIndex];

            TextBoxWidth.Text = _currentRectangle.Width.ToString();
            TextBoxLength.Text = _currentRectangle.Height.ToString();
            TextBoxColor.Text = _currentRectangle.Color.Name;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            TextBoxId.Text = _currentRectangle.Id.ToString();
        }

        private void TextBoxLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(TextBoxLength.Text);
                TextBoxLength.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception)
            {
                TextBoxLength.BackColor = Color.LightPink;
            }
        }

        private void TextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(TextBoxWidth.Text);
                TextBoxWidth.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception)
            {
                TextBoxWidth.BackColor = Color.LightPink;
            }
        }

        private void TextBoxColor_TextChanged(object sender, EventArgs e)
        {
            Color value = Color.FromName(TextBoxColor.Text);
            if (value.A == 0)
                TextBoxColor.BackColor = Color.LightPink;
            else
            {
                _currentRectangle.Color = value;
                TextBoxColor.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private int FindRectangleWithMaxWidth(MyRectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > rectangles[maxWidthIndex].Width) 
                    maxWidthIndex = i;
            }
            return maxWidthIndex;
        }

        private void ButtonFindRectangles_Click(object sender, EventArgs e)
        {
            ListBoxRectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private MyMovie[] GetRandomMovies(int size)
        {
            MyMovie[] myMovies = new MyMovie[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                myMovies[i] = new MyMovie();
                myMovies[i].Rating = ran.NextDouble() + ran.Next(0, 9);
                myMovies[i].YearRelease = ran.Next(1900, DateTime.Now.Year);
                myMovies[i].DurationMinutes = ran.Next(100, 200);
                myMovies[i].Title = "<title>";
                myMovies[i].Genre = "<genre>";
            }
            return myMovies;
        }

        private void InitListBoxMovies(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ListBoxMovies.Items.Add($"Movie {i + 1}");
            }
        }

        private void ListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[ListBoxMovies.SelectedIndex];

            TextBoxTitle.Text = _currentMovie.Title;
            TextBoxDurationMinutes.Text = _currentMovie.DurationMinutes.ToString();
            TextBoxYearRelease.Text = _currentMovie.YearRelease.ToString();
            TextBoxGenre.Text = _currentMovie.Genre;
            TextBoxRating.Text = _currentMovie.Rating.ToString();
        }

        private void TextBoxRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(TextBoxRating.Text);
                TextBoxRating.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception)
            {
                TextBoxRating.BackColor = Color.LightPink;
            }
        }

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = TextBoxTitle.Text;
        }

        private void TextBoxDurationMinutes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationMinutes = int.Parse(TextBoxDurationMinutes.Text);
                TextBoxDurationMinutes.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception)
            {
                TextBoxDurationMinutes.BackColor = Color.LightPink;
            }
        }

        private void TextBoxYearRelease_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.YearRelease = int.Parse(TextBoxYearRelease.Text);
                TextBoxYearRelease.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception)
            {
                TextBoxYearRelease.BackColor = Color.LightPink;
            }
        }

        private void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = TextBoxGenre.Text;
        }        
        
        private int FindMovieWithMaxRating(MyMovie[] movies)
        {
            int maxRatingIndex = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > movies[maxRatingIndex].Rating)
                    maxRatingIndex = i;
            }
            return maxRatingIndex;
        }

        private void ButtonFindMovies_Click(object sender, EventArgs e)
        {
            ListBoxMovies.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MyRectangle newRectangle = RectangleFactory.Randomize(1, PanelRectangle.Width, PanelRectangle.Height)[0];
            _rectangleR.Add(newRectangle);

            ListBoxRectangles1.Items.Add($"{newRectangle.Id}. ({newRectangle.Center} W = {newRectangle.Width}; H = {newRectangle.Height})");

            Panel newPanel = new Panel();
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.Location = new Point((int)(newRectangle.Center.X - newRectangle.Width / 2), (int)(newRectangle.Center.Y - newRectangle.Height / 2));
            newPanel.Width = (int)newRectangle.Width;
            newPanel.Height = (int)newRectangle.Height;

            _rectanglePanels.Add(newPanel);
            PanelRectangle.Controls.Add(newPanel);
            CheckCollision();
        }

        private void ListBoxRectangles1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectangles1.SelectedIndex < 0)
            {
                TextBoxWidthRectangle.Text = string.Empty;
                TextBoxHeightRectangle.Text = string.Empty;
                TextBoxXRectangle.Text = string.Empty;
                TextBoxYRectangle.Text = string.Empty;
                TextBoxIDRectangle.Text = string.Empty;
            }

            else
            {
                _currentRectangleR = _rectangleR[ListBoxRectangles1.SelectedIndex];

                TextBoxWidthRectangle.Text = _currentRectangleR.Width.ToString();
                TextBoxHeightRectangle.Text = _currentRectangleR.Height.ToString();
                TextBoxXRectangle.Text = _currentRectangleR.Center.X.ToString();
                TextBoxYRectangle.Text = _currentRectangleR.Center.Y.ToString();
                TextBoxIDRectangle.Text = _currentRectangleR.Id.ToString();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxRectangles1.SelectedIndex < 0) return;
            _rectangleR.RemoveAt(ListBoxRectangles1.SelectedIndex);
            _rectanglePanels.RemoveAt(ListBoxRectangles1.SelectedIndex);
            PanelRectangle.Controls.RemoveAt(ListBoxRectangles1.SelectedIndex);
            ListBoxRectangles1.Items.RemoveAt(ListBoxRectangles1.SelectedIndex);
            CheckCollision();
        }

        private void TextBoxXRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxXRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxXRectangle.Text);
                _currentRectangleR.Center = new Point2D(text, _currentRectangleR.Center.Y);
                TextBoxXRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles1.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[ListBoxRectangles1.SelectedIndex].Width / 2,
                    _rectanglePanels[ListBoxRectangles1.SelectedIndex].Location.Y);

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxXRectangle.BackColor = Color.LightPink;
            }
        }

        private void TextBoxYRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxYRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxYRectangle.Text);
                _currentRectangleR.Center = new Point2D(_currentRectangleR.Center.X, int.Parse(TextBoxYRectangle.Text));
                TextBoxYRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles1.SelectedIndex].Location = new Point(
                    _rectanglePanels[ListBoxRectangles1.SelectedIndex].Location.X,
                    text - _rectanglePanels[ListBoxRectangles1.SelectedIndex].Height / 2);

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxYRectangle.BackColor = Color.LightPink;
            }
        }

        private void TextBoxWidthRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxWidthRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxWidthRectangle.Text);
                _currentRectangleR.Width = text;
                TextBoxWidthRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles1.SelectedIndex].Width = text;

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxWidthRectangle.BackColor = Color.LightPink;
            }
        }

        private void TextBoxHeightRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxHeightRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxHeightRectangle.Text);
                _currentRectangleR.Height = text;
                TextBoxHeightRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles1.SelectedIndex].Height = text;

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxHeightRectangle.BackColor = Color.LightPink;
            }
        }

        private void ChangeTextElemListBoxRectangle()
        {
            ListBoxRectangles1.Items[ListBoxRectangles1.SelectedIndex] = $"{_rectangleR[ListBoxRectangles1.SelectedIndex].Id}. (" +
                $"{_rectangleR[ListBoxRectangles1.SelectedIndex].Center} W = {_rectangleR[ListBoxRectangles1.SelectedIndex].Width}; " +
                $"H = {_rectangleR[ListBoxRectangles1.SelectedIndex].Height})";
        }

        private void CheckCollision()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangleR[i], _rectangleR[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}
