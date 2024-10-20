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
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();

        private List<OrderData> _orderData = new List<OrderData>();

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

        public OrdersTab()
        {
            InitializeComponent();

            UpdateOrders();
        }

        public void RefreshData()
        {
            UpdateOrders();
        }

        private void UpdateOrders()
        {
            foreach (var customer in _customers)
            {
                //_orders.AddRange(customer.Order);
                foreach (var order in customer.Order)
                {
                    OrderData orderData = new OrderData();
                    orderData.Id = order.Id.ToString();
                    orderData.Address = order.Address;
                    orderData.Status = order.Status.ToString();
                    orderData.Date = order.Date.ToString();
                    orderData.Amount = order.Amount.ToString();
                    orderData.FullName = customer.FullName;
                    orderData.Order = order;

                    _orderData.Add(orderData);
                    orderDataBindingSource.Add(orderData);
                }
            }
            OrdersDataGridView.DataSource = orderDataBindingSource;
        }

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
                OrderData order = _orderData[OrdersDataGridView.SelectedCells[0].RowIndex];
                IdTextBox.Text = order.Id;
                DateTextBox.Text = order.Date;
                StatusComboBox.Text = order.Status;
                addressControl1.Address = order.Address;
                for (int i = 0; i < order.Order.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(order.Order.Items[i].Name);
                }
                AmountTextBox.Text = order.Amount;
            }
        }
    }
}
