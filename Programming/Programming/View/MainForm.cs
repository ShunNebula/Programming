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
                myRectangles[i].Width = ran.Next(0, 100);
                myRectangles[i].Length = ran.Next(0, 100);
                myRectangles[i].Center = new Point2D(ran.Next(0, 100), ran.Next(0, 100));
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
            TextBoxLength.Text = _currentRectangle.Length.ToString();
            TextBoxColor.Text = _currentRectangle.Color.Name;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            TextBoxId.Text = _currentRectangle.Id.ToString();
        }

        private void TextBoxLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(TextBoxLength.Text);
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
    }
}
