﻿using Programming.Model;
using Programming.Resourses;
using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Класс для работы с фильмами.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Список фильмов.
        /// </summary>
        private static MyMovie[] _movies = null;
        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private static MyMovie _currentMovie = null;

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            _movies = GetRandomMovies(5);
            InitListBoxMovies(5);
        }

        /// <summary>
        /// Создание списка случайных фильмов.
        /// </summary>
        /// <param name="size">Количество фильмов.</param>
        /// <returns>Возвращает список фильмов.</returns>
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

        /// <summary>
        /// Заполнение ListBoxMovies перечислением фильмов.
        /// </summary>
        /// <param name="count">Количество фильмов.</param>
        private void InitListBoxMovies(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ListBoxMovies.Items.Add($"Movie {i + 1}");
            }
        }

        /// <summary>
        /// Заполняет TextBox названия, длительности, даты, жанра и рейтинга.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ListBoxMovies.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[ListBoxMovies.SelectedIndex];

            TextBoxTitle.Text = _currentMovie.Title;
            TextBoxDurationMinutes.Text = _currentMovie.DurationMinutes.ToString();
            TextBoxYearRelease.Text = _currentMovie.YearRelease.ToString();
            TextBoxGenre.Text = _currentMovie.Genre;
            TextBoxRating.Text = _currentMovie.Rating.ToString();
        }

        /// <summary>
        /// Проверка и изменение рейтинга.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxRating.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
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

        /// <summary>
        /// Проверка и изменение названия.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxTitle.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = TextBoxTitle.Text;
        }

        /// <summary>
        /// Проверка и изменение длительности.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxDurationMinutes.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
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

        /// <summary>
        /// Проверка и изменение года выхода.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxYearRelease.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
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

        /// <summary>
        /// Изменение жанра.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxGenre.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void TextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = TextBoxGenre.Text;
        }

        /// <summary>
        /// Нахождение индекса фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="movies">Список фильмов.</param>
        /// <returns>Возвращает индекс фильма с наибольшим рейтингом.</returns>
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

        /// <summary>
        /// Поиск фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ButtonFindMovies.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ButtonFindMovies_Click(object sender, EventArgs e)
        {
            ListBoxMovies.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
