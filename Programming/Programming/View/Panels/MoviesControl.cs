using Programming.Model;
using Programming.Resourses;
using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        private static MyMovie[] _movies = null;
        private static MyMovie _currentMovie = null;

        public MoviesControl()
        {
            InitializeComponent();

            _movies = GetRandomMovies(5);
            InitListBoxMovies(5);
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
                TextBoxRating.BackColor = AppColors.trueText;
            }
            catch (Exception)
            {
                TextBoxRating.BackColor = AppColors.falseText;
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
                TextBoxDurationMinutes.BackColor = AppColors.trueText;
            }
            catch (Exception)
            {
                TextBoxDurationMinutes.BackColor = AppColors.falseText;
            }
        }

        private void TextBoxYearRelease_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.YearRelease = int.Parse(TextBoxYearRelease.Text);
                TextBoxYearRelease.BackColor = AppColors.trueText;
            }
            catch (Exception)
            {
                TextBoxYearRelease.BackColor = AppColors.falseText;
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
