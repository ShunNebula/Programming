using System;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Programming.Model
{
    public class Contact
    {
        private string _name;
        private string _surName;
        private int _phoneNumber;

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set {
                Validator.AssertOnPositiveValue(value, nameof(PhoneNumber));
                _phoneNumber = value; }
        }

        public string Name
        {
            get { return _name; } 
            set {
                AssertStringContainsOnlyLetters(value, Name);
                _name = value; } 
        }

        public string SurName
        {
            get { return _surName; }
            set {
                AssertStringContainsOnlyLetters(value, SurName);
                _surName = value; }
        }

        private static void AssertStringContainsOnlyLetters(string value, string property)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                if (!(value[i] >= 65 && value[i] <= 90 || value[i] >= 97 && value[i] <= 122))
                {
                    MessageBox.Show($"Некорректное значение в свойстве {nameof(property)}.");
                    throw new ArgumentException();
                }
            }
        }

        public Contact()
        {
            
        }

        public Contact(string firstName, string lastName, int phoneNumber)
        {
            Name = firstName;
            SurName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
