using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact : INotifyPropertyChanged
    {
        private string _name;
        private string _phone;
        private string _email;

        public string Name 
        {
            get => _name;
            set 
            { 
                OnPropertyChanged(nameof(Name)); 
                _name = value;
            } 
        }
        public string Phone 
        {
            get => _phone; 
            set
            { 
                OnPropertyChanged(nameof(Phone));
                _phone = value;
            }
        }

        public string Email
        {
            get => _email;
            set 
            {
                OnPropertyChanged(nameof(Email));
                _email = value;
            }
        }

        public Contact() { }

        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
