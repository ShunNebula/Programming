using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о песни.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string _name;
        /// <summary>
        /// Автор.
        /// </summary>
        private string _author;
        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _date;
        /// <summary>
        /// Длительность в секундах.
        /// </summary>
        private int _durationSeconds;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name
        { get { return _name; } set {  _name = value; } }
        /// <summary>
        /// Возвращает и задает автора.
        /// </summary>
        public string Author
        { get { return _author; } set { _author = value; } }
        /// <summary>
        /// Возвращает и задает год выпуска. Должно быть положительным и не больше текущего года.
        /// </summary>
        public int Date
        { 
            get { return _date; } 
            set {
                Validator.AssertValueInRange(value, 0, DateTime.Now.Year, nameof(Date));
                _date = value; } 
        }
        /// <summary>
        /// Возвращает и задает длительность в секундах. Должно быть положительным.
        /// </summary>
        public int DurationSeconds
        { 
            get { return _durationSeconds; } 
            set {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds)); 
                _durationSeconds = value; } }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
            
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="author">Автор.</param>
        /// <param name="date">Год выпуска.</param>
        /// <param name="durationSeconds">Длительность в секундах.</param>
        public Song(string name, string author, int date, int durationSeconds)
        {
            Name = name;
            Author = author;
            Date = date;
            DurationSeconds = durationSeconds;
        }
    }
}
