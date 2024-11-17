﻿using ObjectOrientedPractices.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Класс для работы с товарами
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров типа List<Item>
        /// </summary>
        private static List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
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
        /// Заполнение ListBox
        /// </summary>
        private void UpdateListBox()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                ItemsListBox.Items.Add(_items[i].Id.ToString() + ". " + _items[i].Name.ToString());
            }
        }

        /// <summary>
        /// Текущий товар
        /// </summary>
        private static Item _currentItem = null;

        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            UpdateListBox();

            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Проверка и изменение цены товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CostTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CostTextBox.Text) || ItemsListBox.SelectedIndex < 0) return;
            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                CostTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            catch (Exception)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Проверка и изменение название товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - NameTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || ItemsListBox.SelectedIndex < 0) return;
            _currentItem.Name = NameTextBox.Text;
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = _items[ItemsListBox.SelectedIndex].Id.ToString() + ". " + _items[ItemsListBox.SelectedIndex].Name.ToString();
        }

        /// <summary>
        /// Проверка и изменение описания товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - DescriptionTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionTextBox.Text) || ItemsListBox.SelectedIndex < 0) return;
            _currentItem.Info = DescriptionTextBox.Text;
        }

        /// <summary>
        /// Заполнение TextBox Id, цены, названия и описания
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ItemsListBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0)
            {
                IDTextBox.Text = string.Empty;
                CostTextBox.Text = string.Empty;
                NameTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;
                CategoryComboBox.SelectedIndex = -1;
            }
            else
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];

                IDTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = $"{ _currentItem.Cost:n2}";
                NameTextBox.Text = _currentItem.Name.ToString();
                DescriptionTextBox.Text = _currentItem.Info.ToString();
                CategoryComboBox.Text = _currentItem.Category.ToString();
            }
        }

        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - AddButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.Randomize(1)[0];
            _items.Add(newItem);

            ItemsListBox.Items.Add(newItem.Id.ToString() + ". " + newItem.Name.ToString());
        }

        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - RemoveButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) return;
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
        }

        /// <summary>
        /// Очистка всех TextBox
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ItemsListBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Изменение категории товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - CategoryComboBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem is Category selectedCategory && _currentItem != null)
            {
                _currentItem.Category = selectedCategory;
            }
        }
    }
}
