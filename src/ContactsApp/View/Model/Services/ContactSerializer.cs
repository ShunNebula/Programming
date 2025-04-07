using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации
    /// коллекции контактов.
    /// </summary>
    public class ContactSerializer
    {
        #region Поля

        /// <summary>
        /// Путь к файлу, в котором хранятся контакты.
        /// </summary>
        private string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ContactSerializer"/>.
        /// Создаёт директорию, если она не существует.
        /// </summary>
        public ContactSerializer()
        {
            string directoryPath = Path.GetDirectoryName(_filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Сохраняет коллекцию контактов.
        /// </summary>
        /// <param name="contacts">Коллекция контактов для сохранения.</param>
        public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contacts);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сериализации контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Загружает коллекцию контактов из файла.
        /// </summary>
        /// <returns>Коллекцию контактов, загруженная из файла.
        /// Возвращает новую пустую коллекцию, если файл не существует.</returns>
        public ObservableCollection<Contact> LoadContacts()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при десериализации контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                return new ObservableCollection<Contact>();
            }

            return new ObservableCollection<Contact>();
        }

        #endregion
    }
}