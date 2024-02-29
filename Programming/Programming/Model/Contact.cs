using System;

namespace Programming.Model
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private int _phoneNumber;

        public string FirstName
        { get { return _firstName; } set { _firstName = value; } }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set {if (value < 0)
                    throw new ArgumentException();
                _phoneNumber = value; }
        }

        public Contact()
        {
            
        }

        public Contact(string firstName, string lastName, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
