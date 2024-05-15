using System;
using System.Windows.Forms;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;
        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает часы. Должны быть положительными и не больше 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = value; }
        }

        /// <summary>
        /// Возвращает и задает минуты. Должны быть положительными и не больше 60.
        /// </summary>
        public int Minutes
        { 
            get { return _minutes; }
            set {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value; }
        }

        /// <summary>
        /// Возвращает и задает секунды. Должны быть положительными и не больше 60.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value; }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {
            
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
