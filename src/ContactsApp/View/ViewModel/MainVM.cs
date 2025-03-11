using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна приложения.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private ObservableCollection<ContactVM> _contacts;

        /// <summary>
        /// Выбранный контакт из списка.
        /// </summary>
        private ContactVM _selectedContact;

        private bool _edited = false;

        /// <summary>
        /// Флаг, указывающий, находится ли приложение в режими редактрирования.
        /// </summary>
        private bool _isEditMode = false;

        /// <summary>
        /// Флаг, указывающий был ли создан новый контакт.
        /// </summary>
        private bool _isNewContact = false;

        /// <summary>
        /// Сервис для сериализации и десериализации контактов.
        /// </summary>
        private ContactSerializer _serializer = new ContactSerializer();

        private int _selectedIndex;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainVM"/>.
        /// Загружает контакты из файла, создаёт ContactVM и инициализирует команды.
        /// </summary>
        public MainVM()
        {
            ObservableCollection<Contact> loadedContacts = _serializer.LoadContacts();
            Contacts = new ObservableCollection<ContactVM>(loadedContacts.Select(c => new ContactVM(c)));

            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, CanEditOrRemoveContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanEditOrRemoveContact);
            ApplyCommand = new RelayCommand(ApplyContact);
        }

        /// <summary>
        /// Получает или задаёт коллекцию ContactVM для отображения в списке контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contacts));
            }
        }

        /// <summary>
        /// Получает или задаёт выбранный контакт из списка.
        /// </summary>
        public ContactVM SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));

                (EditCommand as RelayCommand)?.RaiseCanExecuteChanged();
                (RemoveCommand as RelayCommand)?.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Получает или задаёт значение, указывающее, находится ли приложение в режиме редактирования.
        /// </summary>
        public bool IsEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                OnPropertyChanged(nameof(IsEditMode));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(ApplyButtonVisibility));
            }
        }

        /// <summary>
        /// Получает значение, указывающее, находится ли приложение в режиме только для чтения.
        /// </summary>
        public bool IsReadOnly => !IsEditMode;

        /// <summary>
        /// Получает значение, указывающее видимость кнопки "Apply".
        /// </summary>
        public Visibility ApplyButtonVisibility => IsEditMode ? Visibility.Visible : Visibility.Collapsed;

        /// <summary>
        /// Получает команду для добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Получает команду для редактирования существующего контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Получает команду для удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Получает команду для применения изменений к контакту.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Обработчик команды AddCommand.
        /// Создаёт новый контакт и добавляет его в коллекцию.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        private void AddContact(object parameter)
        {
            SelectedContact = null;
            var newContact = new Contact();
            var newContactVM = new ContactVM(newContact);
            SelectedContact = newContactVM;
            _isNewContact = true;
            IsEditMode = true;
        }

        /// <summary>
        /// Обработчик команды EditCommand.
        /// Переводи приложение в режим редактирования.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        public void EditContact(object parameter)
        {
            var clonnedContact = new ContactVM(new Contact())
            {
                Email = SelectedContact.Email,
                Phone = SelectedContact.Phone,
                Name = SelectedContact.Name
            };
            _selectedIndex = Contacts.IndexOf(SelectedContact);
            SelectedContact = clonnedContact;
            _edited = true;
            IsEditMode = true;
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда EditCommand или RemoveCommand.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        /// <returns>true, если команда может быть выполнена, иначе false.</returns>
        private bool CanEditOrRemoveContact(object parameter)
        {
            return SelectedContact != null;
        }

        /// <summary>
        /// Обработчик команды RemoveCommand.
        /// Удаляет выбранный контакт из коллекции.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        private void RemoveContact(object parameter)
        {
            if (SelectedContact != null)
            {
                int selectedIndex = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);

                if (Contacts.Count > 0)
                {
                    if (selectedIndex < Contacts.Count)
                    {
                        SelectedContact = Contacts[selectedIndex];
                    }
                    else
                    {
                        SelectedContact = Contacts[Contacts.Count - 1];
                    }
                }
                else
                {
                    SelectedContact = null;
                }

                SaveContacts();
            }
        }

        /// <summary>
        /// Обработчик команды ApplyCommand.
        /// Применяет изменения к контакту и сохраняет их в файл.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        private void ApplyContact(object parameter)
        {
            if (_isNewContact)
            {
                Contacts.Add(SelectedContact);
            }
            else
            {
                Contacts[_selectedIndex] = SelectedContact;
                _selectedIndex = -1;
            }

            IsEditMode = false;
            _isNewContact = false;
            SaveContacts();
        }

        /// <summary>
        /// Сохраняет коллекцию контактов в файл.
        /// </summary>
        private void SaveContacts()
        {
            _serializer.SaveContacts(new ObservableCollection<Contact>(Contacts.Select(x => x.Contact)));
        }

        /// <summary>
        /// Возникает при изменениии значения свойства.
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
    }
}
