using System.ComponentModel;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// <c>ViewModel</c> Для главного окна приложения.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Возникает при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>
        /// для уведомления об изменении свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменённого свойства.</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Экземпляр контакта, содержащий контактную информацию.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Сервис для сериализации и десериализации контактов.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Получает или задаёт ФИО контакта.
        /// </summary>
        public string Name
        {
            get => _contact.Name;
            set 
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Получает или задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Получает или задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get => _contact.Email;
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Получает или задаёт объект <see cref="Contact"/>, представляющий контактную информацию.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Получает команду сохранения контакта.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Получает команду загрузки контакта.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
            Contact = _serializer.LoadContact();

            SaveCommand = new SaveCommand(_serializer, this);
            LoadCommand = new LoadCommand(_serializer, this);
        }
    }
}
