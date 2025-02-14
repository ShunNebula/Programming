using System;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surName;
        /// <summary>
        /// Номер телефона человека.
        /// </summary>
        private int _phoneNumber;

        /// <summary>
        /// Возвращает и задает номер телефона человека. Должен быть положительным.
        /// </summary>
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set {
                Validator.AssertOnPositiveValue(value, nameof(PhoneNumber));
                _phoneNumber = value; }
        }

        /// <summary>
        /// Возвращает и задает имя человека. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get { return _name; } 
            set {
                AssertStringContainsOnlyLetters(value, Name);
                _name = value; } 
        }

        /// <summary>
        /// Возвращает и задает фамилию человека. Должно состоять только из букв.
        /// </summary>
        public string SurName
        {
            get { return _surName; }
            set {
                AssertStringContainsOnlyLetters(value, SurName);
                _surName = value; }
        }

        /// <summary>
        /// Проверяет, что в строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="property">Название свойства.</param>
        /// <exception cref="ArgumentException">Выбрасывает исключенике типа ArgumentException, если строка состоит не только из букв.</exception>
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

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="firstName">Имя человека.</param>
        /// <param name="lastName">Фамилия человека.</param>
        /// <param name="phoneNumber">Номер телефона человека.</param>
        public Contact(string firstName, string lastName, int phoneNumber)
        {
            Name = firstName;
            SurName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
