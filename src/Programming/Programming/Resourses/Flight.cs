using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о рейсах.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Пункт вылета.
        /// </summary>
        private string _departurePoint;
        /// <summary>
        /// Пункт назначения.
        /// </summary>
        private string _destinationPoint;
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int _flightMinute;

        /// <summary>
        /// Возвращает и задает пункт вылета.
        /// </summary>
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set { _departurePoint = value; }
        }

        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set { _destinationPoint = value; }
        }
        
        /// <summary>
        /// Возвращает и задает время полета в минутах.
        /// </summary>
        public int FlightMinute
        {
            get { return _flightMinute; }
            set {
                Validator.AssertOnPositiveValue(value, nameof(FlightMinute));
                _flightMinute = value; }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
            
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт вылета.</param>
        /// <param name="destinationPoint">Пункт назначения.</param>
        /// <param name="flightMinute">Время полета в минутах.</param>
        public Flight(string departurePoint, string destinationPoint, int flightMinute)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightMinute = flightMinute;
        }
    }
}
