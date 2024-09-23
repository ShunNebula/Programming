using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private static List<Item> _items = new List<Item>();

        private static Item _currentItem = null;

        public ItemsTab()
        {
            InitializeComponent();
        }

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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || ItemsListBox.SelectedIndex < 0) return;
            _currentItem.Name = NameTextBox.Text;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionTextBox.Text) || ItemsListBox.SelectedIndex < 0) return;
            _currentItem.Info = DescriptionTextBox.Text;
        }

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
                ItemsListBox.Items.Add(newItem);
            }
            catch (Exception ) 
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) return;
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
        }

        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
        }
    }
}
