using System;

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
                if (value < 0) throw new ArgumentException();
                _durationMinutes = value; }
        }

        public int YearRelease
        {
            get { return _yearRelease; }
            set {if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException();
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
