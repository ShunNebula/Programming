﻿using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Discounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Класс для работы с покупателями
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей типа List<Customer>
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Вызывает и задаёт список покупателей
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateListBox();
            }
        }

        /// <summary>
        /// Обновляет ListBox
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();
            CustomersListBox.Items.AddRange(_customers.ToArray());
        }

        /// <summary>
        /// Текущий покупатель
        /// </summary>
        public static Customer _currentCustomer = null;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполнение TextBox Id, полного имени и адреса
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CustomersListBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                IDTextBox.Text = string.Empty;
                FullNameTextBox.Text = string.Empty;
                addressControl1.Address = null;
                PriorityCheckBox.Checked = false;
                ListBoxDiscounts.Items.Clear();
            }
            else
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                PriorityCheckBox.Checked = _currentCustomer.IsPriority;
                IDTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                addressControl1.Address = _currentCustomer.Address;

                RefreshDiscountsListBox();
            }
        }

        /// <summary>
        /// Добавить покупателя
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - AddButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.Randomize(1)[0];
            _customers.Add(newCustomer);
            CustomersListBox.Items.Add(newCustomer.Id.ToString() + ". " + newCustomer.FullName.ToString());
        }

        /// <summary>
        /// Удалить покупателя
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - RemoveButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0) return;
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
        }

        /// <summary>
        /// Проверка и изменение полного имени
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - FullNameTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) || CustomersListBox.SelectedIndex < 0)
            {
                return;
            }
            _currentCustomer.FullName = FullNameTextBox.Text;
            CustomersListBox.Items[CustomersListBox.SelectedIndex] = IDTextBox.Text + ". " + FullNameTextBox.Text;
        }

        /// <summary>
        /// Очистка всех TextBox
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CustomersListBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CustomersListBox_DoubleClick(object sender, EventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Задаёт приоритетность выбранного покупателя
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - PriorityCheckBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0) return;
            _currentCustomer.IsPriority = PriorityCheckBox.Checked;
        }

        private void ButtonAddDiscounts_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0) return;

            using (AddDiscountForm addDiscountForm = new AddDiscountForm())
            {
                if (addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    Category selectedCategory = addDiscountForm.SelectedCategory;

                    foreach (IDiscount discount in _currentCustomer.Discounts)
                    {
                        if (discount is PercentDiscount percentDiscount && percentDiscount.Category == selectedCategory)
                        {
                            MessageBox.Show("Скидка для этой категории уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    PercentDiscount newDiscount = new PercentDiscount(selectedCategory);
                    _currentCustomer.Discounts.Add(newDiscount);

                    RefreshDiscountsListBox();
                }
            }
        }

        private void RefreshDiscountsListBox()
        {
            ListBoxDiscounts.Items.Clear();
            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                ListBoxDiscounts.Items.Add(discount.Info);
            }
        }

        private void ButtonRemoveDiscounts_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0 || ListBoxDiscounts.SelectedIndex < 1) return;

            _currentCustomer.Discounts.RemoveAt(ListBoxDiscounts.SelectedIndex);
            ListBoxDiscounts.Items.RemoveAt(ListBoxDiscounts.SelectedIndex);
        }
    }
}
