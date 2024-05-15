using System;
using System.Windows.Forms;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class MyMovie
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _title;
        /// <summary>
        /// Длительность в минутах.
        /// </summary>
        private int _durationMinutes;
        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _yearRelease;
        /// <summary>
        /// Жанр.
        /// </summary>
        private string _genre;
        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает рейтинг.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set {_rating = value; }
        }

        /// <summary>
        /// Возвращает и задает длительность в минутах. Должно быть положительным.
        /// </summary>
        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set {
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value; }
        }

        /// <summary>
        /// Возвращает и задает год выпуска. Должно быть положительным и не болье текущего года.
        /// </summary>
        public int YearRelease
        {
            get { return _yearRelease; }
            set {
                Validator.AssertValueInRange(value, 0, DateTime.Now.Year, nameof(YearRelease));
                _yearRelease = value; }
        }

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Возвращает и задает жанр.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="MyMovie"/>.
        /// </summary>
        public MyMovie()
        {
            
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MyMovie"/>.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="durationMinutes">Длительность в минутах.</param>
        /// <param name="yearRelease">Год выпуска.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг.</param>
        public MyMovie(string title, int durationMinutes, int yearRelease, string genre, double rating)
        {
            Rating = rating;
            Title = title;
            DurationMinutes = durationMinutes;
            YearRelease = yearRelease;
            Genre = genre;
        }
    }
}
