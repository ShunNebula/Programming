using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ObjectOrientedPractices.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractices.View
{
    public partial class Check : Form
    {
        public Check(List<Item> items)
        {
            InitializeComponent();

            var cloneItem = items[0].Clone();
            CloneTextBox.Text = ((Item)cloneItem).Name;

            EqualsTextBox.Text = items[0].Equals(items[1]).ToString();

            Equals2TextBox.Text = items[0].Equals(items[0]).ToString();

            CompareTextBox.Text = items[0].CompareTo(items[1]).ToString();
        }
    }
}
