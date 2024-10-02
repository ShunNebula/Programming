using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            ItemsTab itemsTab = new ItemsTab();
            itemsTab.Items = _store.Items;

            CustomersTab customersTab = new CustomersTab();
            customersTab.Customers = _store.Customers;
        }
    }
}
