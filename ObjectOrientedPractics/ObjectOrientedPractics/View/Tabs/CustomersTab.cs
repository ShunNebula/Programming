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
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private static List<Customer> _customers = new List<Customer>();

        private static Customer _currentCustomer = null;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                IDTextBox.Text = string.Empty;
                FullNameTextBox.Text = string.Empty;
                AddressTextBox.Text = string.Empty;
            }
            else
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];

                IDTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.Fullname;
                AddressTextBox.Text = _currentCustomer.Address;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) || string.IsNullOrEmpty(AddressTextBox.Text)) return;
            Customer newCustomer = new Customer();
            newCustomer.Fullname = FullNameTextBox.Text;
            newCustomer.Address = AddressTextBox.Text;
            _customers.Add(newCustomer);
            CustomersListBox.Items.Add(newCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0) return;
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) || CustomersListBox.SelectedIndex < 0) return;
            _currentCustomer.Fullname = FullNameTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddressTextBox.Text) || CustomersListBox.SelectedIndex < 0) return;
            _currentCustomer.Address = AddressTextBox.Text;
        }

        private void CustomersListBox_DoubleClick(object sender, EventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
        }
    }
}
