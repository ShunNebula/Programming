using ObjectOrientedPractices.Services;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о полном адресе
    /// </summary>
    public class Address : ICloneable, IEquatable<Address> 
    {
        /// <summary>
        /// Почтовый индекс
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион
        /// </summary>
        private string _country;

        /// <summary>
        /// Город(населённый пункт)
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                try
                {
                    ValueValidator.AssertIndex(value, nameof(Index));
                    _index = value;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну/регион
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                try
                { 
                    ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                    _country = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт название города(населённого пункта)
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                try
                { 
                    ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                    _city = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт название улицы
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                try
                { 
                    ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                    _street = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                try
                { 
                    ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                    _building = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                    _apartment = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"стр.{_country}, г.{_city}, ул.{_street}, д.{_building}, кв.{_apartment}";
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <inheritdoc/>
        public bool Equals(Address other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return (Index == other.Index &&
                Country == other.Country &&
                City == other.City &&
                Street == other.Street &&
                Building == other.Building &&
                Apartment == other.Apartment);
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != this.GetType()) return false;
            return Equals((Address)other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
