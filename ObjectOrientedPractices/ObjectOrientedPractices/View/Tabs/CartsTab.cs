using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();

        private List<Customer> _customer = new List<Customer>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set 
            { 
                _items = value;
                UpdateListBox(); 
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers 
        { 
            get { return _customer; }
            set 
            { 
                _customer = value; 
                UpdateComboBox(); 
            }
        }

        public Customer CurrentCustomer { get; set; }

        public CartsTab()
        {
            InitializeComponent();

            UpdateListBox();
            UpdateComboBox();
        }

        public void RefreshData()
        {
            UpdateListBox();
            UpdateComboBox();
        }

        /// <summary>
        /// Заполнение ListBox
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();
            for (int i = 0; i < Items.Count; i++)
            {
                ItemsListBox.Items.Add(Items[i].Id.ToString() + ". " + Items[i].Name.ToString());
            }
        }

        private void UpdateComboBox()
        {
            CustomerComboBox.Items.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                CustomerComboBox.Items.Add(Customers[i].FullName);
            }
        }

        private void ChangeCart()
        {
            AmountTextBox.Text = $"{CurrentCustomer.Cart.Amount:n2}";
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();

            CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
            for (int i = 0; i < CurrentCustomer.Cart.Items.Count; i++)
            {
                CartListBox.Items.Add(CurrentCustomer.Cart.Items[i].Name);
                ChangeCart();
            }
        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex > -1)
            {
                CurrentCustomer.Cart.Items.Add(_items[ItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(_items[ItemsListBox.SelectedIndex].Name);

                ChangeCart();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex > -1)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);

                ChangeCart();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Order.Items = CurrentCustomer.Cart.Items;
            CurrentCustomer.Order.Amount = CurrentCustomer.Cart.Amount;
            CurrentCustomer.Order.Status = (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0];
            CurrentCustomer.Order.Address = CurrentCustomer.Address;
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            ChangeCart();
        }

    }
}
