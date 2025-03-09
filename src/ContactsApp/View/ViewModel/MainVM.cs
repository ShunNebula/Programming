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
    public class MainVM : INotifyPropertyChanged
    {
        private ObservableCollection<ContactVM> _contacts;
        private ContactVM _selectedContact;
        private bool _isEditMode = false;
        private ContactSerializer _serializer = new ContactSerializer();

        public ObservableCollection<ContactVM> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contacts));
            }
        }

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

        public bool IsReadOnly => !IsEditMode;

        public Visibility ApplyButtonVisibility => IsEditMode ? Visibility.Visible : Visibility.Collapsed;

        public ICommand AddCommand { get; }

        public ICommand EditCommand { get; }

        public ICommand RemoveCommand { get; }

        public ICommand ApplyCommand { get; }

        public MainVM()
        {
            ObservableCollection<Contact> loadedContacts = _serializer.LoadContacts();
            Contacts = new ObservableCollection<ContactVM>(loadedContacts.Select(c => new ContactVM(c)));

            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, CanEditOrRemoveContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanEditOrRemoveContact);
            ApplyCommand = new RelayCommand(ApplyContact);
        }

        private void AddContact(object parameter)
        {
            IsEditMode = true;
            SelectedContact = null;
            var newContact = new Contact();
            var newContactVM = new ContactVM(newContact);
            Contacts.Add(newContactVM);
            SelectedContact = newContactVM;
        }

        public void EditContact(object parameter)
        {
            IsEditMode = true;
        }

        private bool CanEditOrRemoveContact(object parameter)
        {
            return SelectedContact != null;
        }

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
            }
        }

        private void ApplyContact(object parameter)
        {
            if (SelectedContact != null)
            {
                var existingContact = Contacts.FirstOrDefault(c => c.Name == SelectedContact.Name);

                if (existingContact != null)
                {
                    existingContact.Phone = SelectedContact.Phone;
                    existingContact.Email = SelectedContact.Email;
                }
                else
                {
                    Contacts.Add(SelectedContact);
                }

                IsEditMode = false;
                SaveContacts();
            }
        }

        private void SaveContacts()
        {
            _serializer.SaveContacts(new ObservableCollection<Contact>(Contacts.Select(x => x.Contact)));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
