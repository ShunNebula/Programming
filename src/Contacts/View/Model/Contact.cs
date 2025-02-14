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
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Получает или задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/>. 
        /// (Конструктор по умоляанию)
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/>
        /// с указанными параметрами.
        /// </summary>
        /// <param name="name">ФИО контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        /// <param name="email">Адрес электронной почты контакта.</param>
        public Contact(string name, string phoneNumber, string email) 
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
