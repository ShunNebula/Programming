using ObjectOrientedPractices.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Services;
using System.Data.SqlTypes;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Класс для работы с товарами
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Список товаров типа List<Item>
        /// </summary>
        private static List<Item> _items;

        private List<Item> _displayedItems;

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                FindAndSortItems();
            }
        }

        /// <summary>
        /// Текущий товар
        /// </summary>
        private static Item _currentItem = null;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            OrderByComboBox.Items.AddRange(new string[] { "Name", "Cost (Ascending)", "Cost (Descending)" });
            OrderByComboBox.SelectedIndex = 0;

            FindAndSortItems();

            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновление данных
        /// </summary>
        public void RefreshData()
        {
            FindAndSortItems();
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

                ItemsChanged?.Invoke(this, EventArgs.Empty);
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

            ItemsChanged?.Invoke(this, EventArgs.Empty);
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

            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Заполнение TextBox Id, цены, названия и описания
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ItemsListBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                _currentItem = null;
                IDTextBox.Text = string.Empty;
                CostTextBox.Text = string.Empty;
                NameTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;
                CategoryComboBox.SelectedIndex = -1;
            }
            else
            {
                _currentItem = (Item)ItemsListBox.SelectedItem;

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

            FindAndSortItems();

            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - RemoveButton</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) return;
            Item selectedItem = (Item)ItemsListBox.SelectedItem;
            _items.Remove(selectedItem);

            FindAndSortItems();

            ItemsChanged?.Invoke(this, EventArgs.Empty);
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
            if (ItemsListBox.SelectedIndex != -1 && CategoryComboBox.SelectedItem is Category selectedCategory)
            {
                _currentItem = (Item)ItemsListBox.SelectedItem;
                _currentItem.Category = selectedCategory;

                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Поиск и сортировка ItemsListBox
        /// </summary>
        private void FindAndSortItems()
        {
            if (_items == null) return;

            string searchText = SearchStringTextBox.Text;
            string selectedOrder = OrderByComboBox.SelectedItem.ToString();

            _displayedItems = DataTools.Filter(_items, item =>
                 item.Name.Contains(searchText)
                 );

            switch (selectedOrder)
            {
                case "Name":
                    _displayedItems = DataTools.Sort(_displayedItems, DataTools.CompareByName);

                    break;
                case "Cost (Ascending)":

                    _displayedItems = DataTools.Sort(_displayedItems, DataTools.CompareByCostAscending);

                    break;
                case "Cost (Descending)":

                    _displayedItems = DataTools.Sort(_displayedItems, DataTools.CompareByCostDescending);

                    break;
            }

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _displayedItems;
        }

        /// <summary>
        /// Поиск подстрок в списке
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - SearchStringTextBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void SearchStringTextBox_TextChanged(object sender, EventArgs e)
        {
            FindAndSortItems();
        }

        /// <summary>
        /// Сортировка списка
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - OrderByComboBox</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindAndSortItems();
        }
    }
}
