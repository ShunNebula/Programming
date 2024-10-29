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
    /// <summary>
    /// Класс для работы с корзиной покупателя
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customer = new List<Customer>();

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
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

        /// <summary>
        /// Текущий покупатель
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();

            RefreshData();
        }

        /// <summary>
        /// Обновляет списки покупателей и товаров
        /// </summary>
        public void RefreshData()
        {
            UpdateListBox();
            UpdateComboBox();
        }

        /// <summary>
        /// Заполнение ListBox товарами
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();
            for (int i = 0; i < Items.Count; i++)
            {
                ItemsListBox.Items.Add(Items[i].Id.ToString() + ". " + Items[i].Name.ToString());
            }
        }

        /// <summary>
        /// Заполняет ComboBox покупателями
        /// </summary>
        private void UpdateComboBox()
        {
            CustomerComboBox.Items.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                CustomerComboBox.Items.Add(Customers[i].FullName);
            }
        }

        /// <summary>
        /// Обновляет стоимость корзины
        /// </summary>
        private void ChangeCart()
        {
            AmountTextBox.Text = $"{_currentCustomer.Cart.Amount:n2}";
        }

        /// <summary>
        /// Заполняет корзину при выборе покупателя
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CustomerComboBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();

            _currentCustomer = Customers[CustomerComboBox.SelectedIndex];
            for (int i = 0; i < _currentCustomer.Cart.Items.Count; i++)
            {
                CartListBox.Items.Add(_currentCustomer.Cart.Items[i].Name);
                ChangeCart();
            }
        }

        /// <summary>
        /// Добавляет выбранный товар в корзину
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - AddCartButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void AddCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex > -1 && CustomerComboBox.SelectedIndex > -1)
            {
                _currentCustomer.Cart.Items.Add(_items[ItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(_items[ItemsListBox.SelectedIndex].Name);

                ChangeCart();
            }
        }

        /// <summary>
        /// Удаляет выбранный товар из корзины
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - RemoveItemButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex > -1)
            {
                _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);

                ChangeCart();
            }
        }

        /// <summary>
        /// Создаёт заказ на основе корзину покупателя
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CreateOrderButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count == 0) return;
            if (_currentCustomer.IsPriority)
            {
                PriorityOrder currentOrder = new PriorityOrder(
                    _currentCustomer.Address,
                    new List<Item>(_currentCustomer.Cart.Items),
                    _currentCustomer.Cart.Amount,
                    (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0],
                    DateTime.Now.Date.AddDays(3),
                    "09:00 - 11:00"
                    );

                _currentCustomer.Order.Add(currentOrder);
            }
            else
            {
                Order currentOrder = new Order(
                    _currentCustomer.Address,
                    new List<Item>(_currentCustomer.Cart.Items),
                    _currentCustomer.Cart.Amount,
                    (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0]
                    );

                _currentCustomer.Order.Add(currentOrder);
            }
            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();

            ChangeCart();
        }

        /// <summary>
        /// Очищает корзину покупателя
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ClearCartButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();

            ChangeCart();
        }
    }
}
