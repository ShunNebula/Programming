using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Services;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractices.View.Controls
{
    /// <summary>
    /// Класс для работы с адресом
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает и задаёт адрес покупателя
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                LoadAddress();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            LoadAddress();
        }

        /// <summary>
        /// Вводит адрес в TextBox
        /// </summary>
        private void LoadAddress()
        {
            if (this.Address != null)
            {
                IndexTextBox.Text = _address.Index.ToString();
                CountryTextBox.Text = _address.Country;
                CityTextBox.Text = _address.City;
                StreetTextBox.Text = _address.Street;
                BuildingTextBox.Text = _address.Building;
                ApartmentTextBox.Text = _address.Apartment;
            }
            else
            {
                IndexTextBox.Text = "100000";
                CountryTextBox.Text = " ";
                CityTextBox.Text = " ";
                StreetTextBox.Text = " ";
                BuildingTextBox.Text = " ";
                ApartmentTextBox.Text = " ";
            }
        }

        /// <summary>
        /// Проверка и изменение почтового индекса
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - IndexTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;
            if (!string.IsNullOrEmpty(IndexTextBox.Text) && int.TryParse(IndexTextBox.Text, out int n) && (n <= 999999 && n >= 100000))
            {
                IndexTextBox.BackColor = SystemColors.Window;
                _address.Index = n;
            }
            else
            {
                IndexTextBox.BackColor = Color.LightPink;
                MessageBox.Show(nameof(_address.Index) + " должен быть 6-значным числом.");
            }
        }

        /// <summary>
        /// Проверка и изменение страны
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CountryTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;
            if (!string.IsNullOrEmpty(CountryTextBox.Text) && CountryTextBox.Text.Length <= 50)
            {
                CountryTextBox.BackColor = SystemColors.Window;
                _address.Country = CountryTextBox.Text;
            }
            else
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Проверка и изменение улицы
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - StreetTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;
            if (!string.IsNullOrEmpty(StreetTextBox.Text) && StreetTextBox.Text.Length <= 50)
            {
                StreetTextBox.BackColor = SystemColors.Window;
                _address.Street = StreetTextBox.Text;
            }
            else
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Проверка  и изменение города
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CityTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;
            if (!string.IsNullOrEmpty(CityTextBox.Text) && CityTextBox.Text.Length <= 100)
            {
                CityTextBox.BackColor = SystemColors.Window;
                _address.City = CityTextBox.Text;
            }
            else
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Проверка и изменение номера дома
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - BuildingTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;
            if (!string.IsNullOrEmpty(BuildingTextBox.Text) && BuildingTextBox.Text.Length <= 10)
            {
                BuildingTextBox.BackColor = SystemColors.Window;
                _address.Building = BuildingTextBox.Text;
            }
            else
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Проверка и изменение номера квартиры
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ApartmentTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_address == null) return;
            if (!string.IsNullOrEmpty(ApartmentTextBox.Text) && ApartmentTextBox.Text.Length <= 10)
            {
                ApartmentTextBox.BackColor = SystemColors.Window;
                _address.Apartment = ApartmentTextBox.Text;
            }
            else
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
