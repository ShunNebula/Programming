using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        private string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        public ContactSerializer()
        {
            string directoryPath = Path.GetDirectoryName(_filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(_filePath, json);
        }

        public ObservableCollection<Contact> LoadContacts()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json);
            }
            return new ObservableCollection<Contact>();
        }
    }
}
