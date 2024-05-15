using System;

namespace Programming.Model
{
    public class Song
    {
        private string _name;
        private string _author;
        private string _date;
        private int _durationSeconds;

        public string Name
        { get { return _name; } set {  _name = value; } }
        public string Author
        { get { return _author; } set { _author = value; } }
        public string Date
        { get { return _date; } set { _date = value; } }
        public int DurationSeconds
        { 
            get { return _durationSeconds; } 
            set {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds)); 
                _durationSeconds = value; } }

        public Song()
        {
            
        }

        public Song(string name, string author, string date, int durationSeconds)
        {
            Name = name;
            Author = author;
            Date = date;
            DurationSeconds = durationSeconds;
        }
    }
}
