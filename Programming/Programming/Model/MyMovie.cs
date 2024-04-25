using System;
using System.Windows.Forms;

namespace Programming.Model
{
    internal class MyMovie
    {
        private string _title;
        private int _durationMinutes;
        private int _yearRelease;
        private string _genre;
        private double _rating;

        public double Rating
        {
            get { return _rating; }
            set {_rating = value; }
        }

        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set {
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value; }
        }

        public int YearRelease
        {
            get { return _yearRelease; }
            set {
                Validator.AssertValueInRange(value, 0, DateTime.Now.Year, nameof(YearRelease));
                _yearRelease = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public MyMovie()
        {
            
        }

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
