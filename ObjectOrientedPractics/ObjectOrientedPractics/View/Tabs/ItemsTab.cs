﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
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
        /// Текущий товар
        /// </summary>
        private static Item _currentItem = null;
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
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
            }
            else
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];

                IDTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameTextBox.Text = _currentItem.Name.ToString();
                DescriptionTextBox.Text = _currentItem.Info.ToString();
            }
        }
        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - AddButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CostTextBox.Text) || string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(DescriptionTextBox.Text)) return;
            try
            {
                Item newItem = new Item();
                newItem.Cost = double.Parse(CostTextBox.Text);
                newItem.Name = NameTextBox.Text;
                newItem.Info = DescriptionTextBox.Text;
                _items.Add(newItem);
                CostTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ItemsListBox.Items.Add(newItem.Id.ToString() + ". " + newItem.Name.ToString());
            }
            catch (Exception ) 
            {
                CostTextBox.BackColor = Color.LightPink;
            }
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
    }
}
