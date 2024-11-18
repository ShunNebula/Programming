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
using ObjectOrientedPractices.Model.Orders;

namespace ObjectOrientedPractices
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            itemsTab1.Items = _store.Items;

            customersTab1.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;
        }

        /// <summary>
        /// Переключение между вкладками
        /// </summary>
        /// <param name="sender">Ссылка на объект, зажигающий событие</param>
        /// <param name="e">Данные о событие</param>
        private void TabControl1_SelectedTabChanged(object sender, EventArgs e)
        {
            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
        }

        /// <summary>
        /// Загрузка главного окна
        /// </summary>
        /// <param name="sender">Ссылка на объект, зажигающий событие</param>
        /// <param name="e">Данные о событие</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            itemsTab1.ItemsChanged += Tabs_DataChanges;
        }

        /// <summary>
        /// Событие для обновления данных
        /// </summary>
        /// <param name="sender">Ссылка на объект, зажигающий событие</param>
        /// <param name="e">Данные о событие</param>
        private void Tabs_DataChanges(object sender, EventArgs e)
        {
            itemsTab1.RefreshData();
            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
        }
    }
}
