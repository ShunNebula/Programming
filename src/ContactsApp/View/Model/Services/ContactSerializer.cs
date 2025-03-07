using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        private readonly string _folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");

        public ContactSerializer() 
        { 
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        public void SaveContact(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);
            string filePath = Path.Combine(_folderPath, $"contact{contact.Name}");

            File.WriteAllText(filePath, json);
        }

        public Contact[] LoadContact()
        {
            string[] files = Directory.GetFiles(_folderPath);
            Contact[] contacts = new Contact[] { };
            if (files.Length != 0)
            {
                foreach (string filePath in files)
                {
                    string json = File.ReadAllText(filePath);
                    contacts.Append(JsonConvert.DeserializeObject<Contact>(json));
                }
            }

            return contacts;
        }
    }
}
