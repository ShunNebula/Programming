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
        /// Список допустимых времён доставки
        /// </summary>
        private List<string> _acceptableDeliveryTimes = new List<string>()
        {
            "09:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Таблица всех заказов
        /// </summary>
        private DataTable _orderData = new DataTable();

        /// <summary>
        /// Выбранный заказ
        /// </summary>
        private Order _selectedOrder = new Order();

        /// <summary>
        /// Выбранный приоритетный заказ
        /// </summary>
        private PriorityOrder _selectedPriorityOrder = null;

        /// <summary>
        /// Текущий заказ
        /// </summary>
        private static int _currentIndex = -1;

        /// <summary>
        /// Список заказов
        /// </summary>
        private static List<Order> _orders = new List<Order>();

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

            _orderData.Columns.Add("Id", typeof(string));
            _orderData.Columns.Add("Date", typeof(string));
            _orderData.Columns.Add("FullName", typeof(string));
            _orderData.Columns.Add("Address", typeof(string));
            _orderData.Columns.Add("Amount", typeof(string));
            _orderData.Columns.Add("Status", typeof(string));

            UpdateOrders();

            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            StatusComboBox.SelectedIndex = -1;

            DeliveryTimeComboBox.Items.AddRange(_acceptableDeliveryTimes.ToArray());
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
            _orders.Clear();
            _orderData.Clear();
            OrdersDataGridView.DataSource = null;
            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    DataRow row = _orderData.NewRow();
                    row["Id"] = order.Id;
                    row["Date"] = order.Date.ToString();
                    row["FullName"] = customer.FullName;
                    row["Address"] = order.Address.ToString();
                    row["Amount"] = $"{order.Amount:n2}";
                    row["Status"] = order.Status.ToString();

                    _orderData.Rows.Add(row);

                    _orders.Add(order);
                }
            }
            
            OrdersDataGridView.DataSource = _orderData;
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
                _currentIndex = -1;
            }
            else
            {
                _currentIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
                IdTextBox.Text = _orders[_currentIndex].Id.ToString();
                DateTextBox.Text = _orders[_currentIndex].Date.ToString();
                StatusComboBox.Text = _orders[_currentIndex].Status.ToString();
                addressControl1.Address = _orders[_currentIndex].Address;
                for (int i = 0; i < _orders[_currentIndex].Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(_orders[_currentIndex].Items[i].Name);
                }
                AmountTextBox.Text = $"{_orders[_currentIndex].Amount:n2}";

                _selectedOrder = _orders[_currentIndex];

                if (_selectedOrder is PriorityOrder priority)
                {
                    _selectedPriorityOrder = priority;
                    PriorityPanel.Visible = true;
                    DeliveryTimeComboBox.Text = _selectedPriorityOrder.DesiredDeliveryTime;
                }
                else
                {
                    _selectedPriorityOrder = null;
                    PriorityPanel.Visible = false;
                }
            }
        }


        /// <summary>
        /// Изменение статуса заказа
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - StatusComboBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedItem is OrderStatus selectedStatus && _currentIndex != -1)
            {
                _orderData.Rows[_currentIndex]["Status"] = selectedStatus.ToString();
                _orders[_currentIndex].Status = selectedStatus;
            }
        }

        /// <summary>
        /// Изменение времени доставки заказа
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - DeliveryTimeComboBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_acceptableDeliveryTimes.Contains(DeliveryTimeComboBox.SelectedItem))
            {
                _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTimeComboBox.Text;
            }
        }
    }
}
