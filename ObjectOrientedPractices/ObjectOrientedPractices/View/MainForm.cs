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
        }
    }
}
