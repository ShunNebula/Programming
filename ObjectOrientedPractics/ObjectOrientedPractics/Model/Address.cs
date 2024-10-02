using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о полном адресе
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс
        /// </summary>
        int _index;
        /// <summary>
        /// Страна/регион
        /// </summary>
        string _country;
        /// <summary>
        /// Город(населённый пункт)
        /// </summary>
        string _city;
        /// <summary>
        /// Улица
        /// </summary>
        string _street;
        /// <summary>
        /// Номер дома
        /// </summary>
        string _building;
        /// <summary>
        /// Номер квартиры/помещения
        /// </summary>
        string _apartment;
        /// <summary>
        /// Возвращает и задаёт почтовый индекс
        /// </summary>
        public int Index 
        { 
            get { return _index; } 
            set { _index = value; } 
        }
        /// <summary>
        /// Возвращает и задаёт страну/регион
        /// </summary>
        public string Country
        { 
            get { return _country; } 
            set { _country = value; } 
        }
        /// <summary>
        /// Возвращает и задаёт название города(населённого пункта)
        /// </summary>
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        /// <summary>
        /// Возвращает и задаёт название улицы
        /// </summary>
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        /// <summary>
        /// Возвращает и задаёт номер дома
        /// </summary>
        public string Building
        {
            get { return _building; }
            set { _building = value; }
        }
        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {

        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс</param>
        /// <param name="country">Страна/регион</param>
        /// <param name="city">Город(населённый пункт)</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Номер дома</param>
        /// <param name="apartment">Номер квартиры/помещения</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
