using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace View.Model
{
    /// <summary>
    /// Представляет контактную информацию.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        #region Поля

        /// <summary>
        /// Приватное поле для хранения имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Приватное поле для хранения номера телефона контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Приватное поле для хранения адреса электронной почты контакта.
        /// </summary>
        private string _email;

        #endregion

        #region Свойства

        [StringLength(100)]
        /// <summary>
        /// Получает или задаёт ФИО контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        [StringLength(100)]
        [RegularExpression(@"^\+[0-9]\s?\(?\d{3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2}$")]
        /// <summary>
        /// Получает или задаёт номер телефона контакта.
        /// </summary>
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        [StringLength(100)]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        /// <summary>
        /// Получает или задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/>.
        /// (Конструктор по умолчанию)
        /// </summary>
        public Contact() { }

        #endregion

        #region IDataErrorInfo

        /// <summary>
        /// Возвращает сообщение об ошибке для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства, для которого нужно получить сообщение об ошибке.</param>
        /// <returns>Сообщение об ошибке, если свойство недействительно, иначе <c>null</c>.</returns>
        public string this[string propertyName]
        {
            get
            {
                string error = null;

                switch (propertyName)
                {
                    case nameof(Name):
                        if (string.IsNullOrEmpty(Name))
                            error = "Имя не может быть пустым.";
                        else if (Name?.Length > 100)
                            error = "Имя не должно превышать 100 символов.";

                        break;
                    case nameof(Phone):
                        if (string.IsNullOrEmpty(Phone))
                            error = "Номер телефона не может быть пустым.";
                        else if (Phone?.Length > 100)
                            error = "Номер телефона не должен превышать 100 символов.";
                        else if (!System.Text.RegularExpressions.Regex.IsMatch(Phone, @"^\+[0-9]\s?\(?\d{3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2}$"))
                            error = "Номер телефона должен содержать только цифры или символы +-().";

                        break;
                    case nameof(Email):
                        if (string.IsNullOrEmpty(Email))
                            error = "Адрес почты не может быть пустым.";
                        else if (Email?.Length > 100)
                            error = "Адрес почты не должен превышать 100 символов.";
                        else if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            error = "Неправильный формат адреса почты.";

                        break;
                }

                return error;
            }
        }

        /// <summary>
        /// Возвращает сообщение об ошибке для всего объекта.
        /// </summary>
        public string Error
        {
            get { return null; }
        }

        #endregion

        #region INotifyPropertyChanged

        /// <summary>
        /// Возникает при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>
        /// для уведомления об изменении свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменённого свойства.</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}