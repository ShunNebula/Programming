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

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Класс для работы с заказами
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Список всех заказов
        /// </summary>
        private List<OrderData> _orderData = new List<OrderData>();

        /// <summary>
        /// Текущий заказ
        /// </summary>
        private static OrderData _currentOrder = null;

        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers 
        { 
            get {  return _customers; }
            set 
            {
                _customers = value;
                UpdateOrders();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            UpdateOrders();

            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            StatusComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновляет таблицу заказов
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Заполняет таблицу заказами
        /// </summary>
        private void UpdateOrders()
        {
            orderDataBindingSource.Clear();
            OrdersDataGridView.DataSource = null;
            foreach (var customer in _customers)
            {
                foreach (var order in customer.Order)
                {
                    OrderData orderData = new OrderData();
                    orderData.Id = (order.Id / 2).ToString();
                    orderData.Address = order.Address;
                    orderData.Status = order.Status.ToString();
                    orderData.Date = order.Date.ToString();
                    orderData.Amount = $"{order.Amount:n2}";
                    orderData.FullName = customer.FullName;
                    orderData.Order = order;

                    _orderData.Add(orderData);
                    orderDataBindingSource.Add(orderData);
                }
            }
            OrdersDataGridView.DataSource = orderDataBindingSource;
        }

        /// <summary>
        /// Выводит данные о выбранном заказе
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - OrdersDataGridView</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrderItemsListBox.Items.Clear();
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                IdTextBox.Text = string.Empty;
                DateTextBox.Text = string.Empty;
                StatusComboBox.Text = string.Empty;
                addressControl1.Address = null;
                AmountTextBox.Text = string.Empty;
            }
            else
            {
                _currentOrder = _orderData[OrdersDataGridView.SelectedCells[0].RowIndex];
                IdTextBox.Text = _currentOrder.Id;
                DateTextBox.Text = _currentOrder.Date;
                StatusComboBox.Text = _currentOrder.Status;
                addressControl1.Address = _currentOrder.Address;
                for (int i = 0; i < _currentOrder.Order.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(_currentOrder.Order.Items[i].Name);
                }
                AmountTextBox.Text = _currentOrder.Amount;
            }
        }

        /// <summary>
        /// Изменение статуса заказа
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - StatusComboBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedItem is OrderStatus selectedStatus && _currentOrder != null)
            {
                _currentOrder.Status = selectedStatus.ToString();
            }
        }
    }
}
