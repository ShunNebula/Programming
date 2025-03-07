using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string _name;
        private string _phone;
        private string _email;

        public string Name
        {
            get { return _name; }
            set
            {
                OnPropertyChanged(nameof(Name));
                _name = value;
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                OnPropertyChanged(nameof(Phone));
                _phone = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                OnPropertyChanged(nameof(Email));
                _email = value;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
