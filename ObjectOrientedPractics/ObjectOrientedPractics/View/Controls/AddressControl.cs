using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();

        public Address Address
        {
            get { return _address; }
            set 
            { 
                _address = value;
                LoadAddress();
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            LoadAddress();
        }

        private void LoadAddress()
        {
            IndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IndexTextBox.Text) && int.TryParse(IndexTextBox.Text, out int n) && (n <= 999999 && n >= 100000))
            {
                IndexTextBox.BackColor = SystemColors.Window;
                _address.Index = n;
            }
            else
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
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
