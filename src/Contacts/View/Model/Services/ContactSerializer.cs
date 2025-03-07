using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации и 
    /// десериализации контактной информации.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Получает путь до файла, гда хранятся контакты.
        /// </summary>
        private string _filePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), 
            "Contacts", 
            "contacts.json"
            );

        /// <summary>
        /// Инициализирует новый экземпляр 
        /// класса <see cref="ContactSerializer"/>
        /// и создаёт директорию для хранения файлов контактов, 
        /// если она не существует.
        /// </summary>
        public ContactSerializer()
        {
            if (!Directory.Exists(Path.GetDirectoryName(_filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
            }
        }

        /// <summary>
        /// Сериализует объект <see cref="Contact"/>
        /// в JSON и сохраняет его в файл.
        /// </summary>
        /// <param name="contact">Объект <see cref="Contact"/>
        /// для сохранения</param>
        public void SaveContact(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Десериализирует объект <see cref="Contact"/> из JSON,
        /// хранящегося в файле. Если файл не существует,
        /// возвращает новый экземпляр <see cref="Contact"/>.
        /// </summary>
        /// <returns>Объект <see cref="Contact"/>, десериализованный
        /// из файла, или новый экземпляр <see cref="Contact"/>,
        /// если файл не найден.</returns>
        public Contact LoadContact() 
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<Contact>(json);
            }

            return new Contact();
        }
    }
}
