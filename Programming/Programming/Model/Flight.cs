using System;

namespace Programming.Model
{
    public class Flight
    {
        private string _departurePoint;
        private string _destinationPoint;
        private int _flightMinute;

        public string DeparturePoint
        {
            get { return _departurePoint; }
            set { _departurePoint = value; }
        }

        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set { _destinationPoint = value; }
        }

        public int FlightMinute
        {
            get { return _flightMinute; }
            set {
                Validator.AssertOnPositiveValue(value, nameof(FlightMinute));
                _flightMinute = value; }
        }

        public Flight()
        {
            
        }

        public Flight(string departurePoint, string destinationPoint, int flightMinute)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightMinute = flightMinute;
        }
    }
}
