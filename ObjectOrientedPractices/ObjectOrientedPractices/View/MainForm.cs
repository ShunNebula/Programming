using ObjectOrientedPractices.Model;
using System;
using ObjectOrientedPractices.View.Tabs;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractices
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();

            itemsTab1.Items = _store.Items;

            customersTab1.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;

            discountsTab1.Items = _store.Items;
            percentDiscountTab1.Items = _store.Items;
        }

        private void tabControl1_SelectedTabChanged(object sender, EventArgs e)
        {
            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
            discountsTab1.UpdateLabel();
            percentDiscountTab1.UpdateLabel();
        }
    }
}
