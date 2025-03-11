using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Представляет контактную информацию.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Получает или задаёт ФИО контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задаёт номер телефона контакта.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Получает или задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/>.
        /// (Конструктор по умолчанию)
        /// </summary>
        public Contact() { }
    }
}
