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
        /// Таблица всех заказов
        /// </summary>
        private DataTable _orderData = new DataTable();

        /// <summary>
        /// Текущий заказ
        /// </summary>
        private static int _currentIndex = -1;

        private static Dictionary<string, Address> _addresses = new Dictionary<string, Address>();

        private static Dictionary<string, Order> _orders = new Dictionary<string, Order>();

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
            _addresses.Clear();
            _orders.Clear();
            _orderData.Clear();
            OrdersDataGridView.DataSource = null;
            foreach (var customer in _customers)
            {
                foreach (var order in customer.Order)
                {
                    DataRow row = _orderData.NewRow();
                    row["Id"] = order.Id;
                    row["Date"] = order.Date.ToString();
                    row["FullName"] = customer.FullName;
                    row["Address"] = order.Address.ToString();
                    row["Amount"] = $"{order.Amount:n2}";
                    row["Status"] = order.Status.ToString();

                    _orderData.Rows.Add(row);

                    _addresses[order.Id.ToString()] = order.Address;
                    _orders[order.Id.ToString()] = order;
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
                IdTextBox.Text = _orderData.Rows[_currentIndex]["Id"].ToString();
                DateTextBox.Text = _orderData.Rows[_currentIndex]["Date"].ToString();
                StatusComboBox.Text = _orderData.Rows[_currentIndex]["Status"].ToString();
                addressControl1.Address = _addresses[_orderData.Rows[_currentIndex]["Id"].ToString()];
                for (int i = 0; i < _orders[_orderData.Rows[_currentIndex]["Id"].ToString()].Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(_orders[_orderData.Rows[_currentIndex]["Id"].ToString()].Items[i].Name);
                }
                AmountTextBox.Text = _orderData.Rows[_currentIndex]["Amount"].ToString();
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
            }
        }
    }
}
