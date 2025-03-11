﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для представления контакта в UI.
    /// Оборачивает объект Contact и реализует INotifyPropertyChanged.
    /// </summary>
    public class ContactVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект <see cref="Contact"/>, который нужно обернуть.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, 
        /// если <paramref name="contact"/> равен null.</exception>
        public ContactVM(Contact contact)
        {
            Contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }

        public ContactVM(string name, string phone, string email)
        {
            Contact = new Contact()
            {
                Name = name,
                Phone = phone,
                Email = email
        };
        }

        /// <summary>
        /// Получает объект <see cref="Contact"/>, который представляет контактные данные.
        /// </summary>
        public Contact Contact { get; }

        /// <summary>
        /// Получает или задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Получает или задаёт номер телефона контакта.
        /// </summary>
        public string Phone
        {
            get => Contact.Phone;
            set
            {
                Contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Получает или задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

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
    }
}
