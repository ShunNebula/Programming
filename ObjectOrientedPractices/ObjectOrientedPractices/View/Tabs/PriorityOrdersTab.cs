using ObjectOrientedPractices.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Заказ приоритетного обслуживания
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();

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
        /// Создаёт экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());

            DeliveryTimeComboBox.Items.AddRange(_acceptableDeliveryTimes.ToArray());

            IdTextBox.Text = _priorityOrder.Id.ToString();
            DateTextBox.Text = _priorityOrder.Date.ToString();
            addressControl1.Address = _priorityOrder.Address;
            AmountTextBox.Text = _priorityOrder.Amount.ToString();
        }

        /// <summary>
        /// Создаёт случайный товар и добавляет его в заказ
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - AddItemButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.Randomize(1)[0];
            _priorityOrder.Items.Add(newItem);

            _priorityOrder.Amount += newItem.Cost;

            OrderItemsListBox.Items.Add(newItem.Name);

            UpdateAmount();
        }

        /// <summary>
        /// Удаляет выбранный товар
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - RemoveItemButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex < 0) return;
            _priorityOrder.Amount -= _priorityOrder.Items[OrderItemsListBox.SelectedIndex].Cost;
            _priorityOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);

            if (OrderItemsListBox.SelectedIndex != OrderItemsListBox.Items.Count - 1)
            {
                OrderItemsListBox.SelectedIndex += 1;

                OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex - 1);
            }
            else
            {
                OrderItemsListBox.SelectedIndex -= 1;

                OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex + 1);
            }
            UpdateAmount();
        }

        /// <summary>
        /// Пересоздаёт объект заказа
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ClearOrderButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = null;

            _priorityOrder = new PriorityOrder();

            UpdatePriorityOrder();
        }

        /// <summary>
        /// Обновление элементов управления
        /// </summary>
        private void UpdatePriorityOrder()
        {
            OrderItemsListBox.Items.Clear();
        }

        /// <summary>
        /// Обновление общей стоимости заказа
        /// </summary>
        private void UpdateAmount()
        {
            AmountTextBox.Text = $"{_priorityOrder.Amount:n2}";
        }
    }
}
