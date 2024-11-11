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
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Model.Orders;
using ObjectOrientedPractices.Model.Discounts;

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
        private List<Customer> _customers = new List<Customer>();

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
                UpdateItemsListBox(); 
            }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers 
        { 
            get { return _customers; }
            set 
            { 
                _customers = value; 
                UpdateCustomersComboBox(); 
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
            UpdateItemsListBox();
            UpdateCustomersComboBox();
        }

        /// <summary>
        /// Заполнение ListBox товарами
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();

            if (_items != null)
            {
                foreach (Item item in _items)
                {
                    ItemsListBox.Items.Add($"{item.Id}. {item.Name}");
                }
            }
        }

        /// <summary>
        /// Заполняет ComboBox покупателями
        /// </summary>
        private void UpdateCustomersComboBox()
        {
            CustomerComboBox.Items.Clear();

            if (_customers != null)
            {
                foreach (var customer in _customers)
                {
                    CustomerComboBox.Items.Add(customer.FullName);
                }
            }
        }

        private void UpdateDiscountsCheckedListBox()
        {
            DiscountsCheckedListBox.Items.Clear();

            if (_currentCustomer != null)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    DiscountsCheckedListBox.Items.Add(discount.Info, true);
                }
            }
            RefreshTotalAmountLabel();
        }

        private void UpdateCartListBox()
        {
            CartListBox.Items.Clear();
            foreach (var item in _currentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(item.Name);
            }
            UpdateAmountLabel();
            RefreshTotalAmountLabel();
        }

        private void UpdateAmountLabel()
        {
            AmountLabel.Text = _currentCustomer?.Cart?.Amount.ToString("C") ?? "0.00";
        }

        private void RefreshTotalAmountLabel()
        {
            double discountAmount = CalculateDiscount();
            double totalAmount = _currentCustomer.Cart.Amount - discountAmount;
            LabelDiscountAmount.Text = discountAmount.ToString("C");
            TotalAmountLabel.Text = totalAmount.ToString("C");
        }

        private double CalculateDiscount()
        {
            double discountAmount = 0;
            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                discountAmount += _currentCustomer.Discounts[index].Calculate(_currentCustomer.Cart.Items);
            }

            return discountAmount;
        }

        /// <summary>
        /// Заполняет корзину при выборе покупателя
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CustomerComboBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            DiscountsCheckedListBox.Items.Clear();

            _currentCustomer = Customers[CustomerComboBox.SelectedIndex];
            for (int i = 0; i < _currentCustomer.Cart.Items.Count; i++)
            {
                CartListBox.Items.Add(_currentCustomer.Cart.Items[i].Name);
                UpdateCartListBox();
            }
            UpdateDiscountsCheckedListBox();
            UpdateAmountLabel();
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
                
                UpdateCartListBox();
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

                UpdateCartListBox();
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

            double discountAmount = 0;
            List<IDiscount> selectedDiscounts = new List<IDiscount>(); // Список выбранных скидок

            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                var discount = _currentCustomer.Discounts[index];
                discountAmount += discount.Apply(_currentCustomer.Cart.Items);
                selectedDiscounts.Add(discount); // Добавляем в список выбранных
            }

            if (_currentCustomer.IsPriority)
            {
                PriorityOrder currentOrder = new PriorityOrder(
                    _currentCustomer.Address,
                    new List<Item>(_currentCustomer.Cart.Items),
                    _currentCustomer.Cart.Amount,
                    (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0],
                    discountAmount,
                    DateTime.Now.Date.AddDays(3),
                    "09:00 - 11:00"
                    );

                _currentCustomer.Orders.Add(currentOrder);
            }
            else
            {
                Order currentOrder = new Order(
                    _currentCustomer.Address,
                    new List<Item>(_currentCustomer.Cart.Items),
                    _currentCustomer.Cart.Amount,
                    (OrderStatus)Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray()[0],
                    discountAmount
                    );

                _currentCustomer.Orders.Add(currentOrder);
            }

            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }

            UpdateDiscountsCheckedListBox();

            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();

            UpdateCartListBox();
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

            UpdateCartListBox();
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTotalAmountLabel();
        }
    }
}
