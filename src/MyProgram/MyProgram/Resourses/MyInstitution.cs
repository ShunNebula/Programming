using MyProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram.Resourses
{
    /// <summary>
    /// Класс для работы с заведениями.
    /// </summary>
    public class MyInstitution
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string _title;
        /// <summary>
        /// Адресс.
        /// </summary>
        private string _address;
        /// <summary>
        /// Категория.
        /// </summary>
        private string _category;
        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Title
        { get { return _title; } set {  _title = value; } }

        /// <summary>
        /// Возвращает и задает адресс.
        /// </summary>
        public string Address
        { get { return _address; } set { _address = value; } }

        /// <summary>
        /// Возвращает и задает катигорию.
        /// </summary>
        public string Category
        { get { return _category; } set { _category = value; } }

        /// <summary>
        /// Возвращает и задает рейтинг. 
        /// </summary>
        public double Rating
        { 
            get { return _rating; } 
            set { _rating = value; } 
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="MyInstitution"/>.
        /// </summary>
        public MyInstitution()
        {
            
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="MyInstitution"/>.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="address">Адресс.</param>
        /// <param name="category">Категория.</param>
        /// <param name="rating">Рейтинг.</param>
        public MyInstitution(string title, string address, string category, double rating)
        {
            Title = title;
            Address = address;
            Category = category;
            Rating = rating;
        }
    }
}
