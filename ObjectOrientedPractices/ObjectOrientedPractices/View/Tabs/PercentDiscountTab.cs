using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Discounts;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class PercentDiscountTab : UserControl
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Проценты
        /// </summary>
        private IDiscount percent = new PercentDiscount(Category.Clothing);

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                UpdateLabel();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscountTab"/>.
        /// </summary>
        public PercentDiscountTab()
        {
            InitializeComponent();
            UpdateLabel();
            UpdateInfo();
        }

        /// <summary>
        /// Обновление LabelInfo
        /// </summary>
        private void UpdateInfo()
        {
            LabelInfo.Text = $"Info: {percent.Info}";
        }

        /// <summary>
        /// Обновление LabelProductAmount
        /// </summary>
        public void UpdateLabel()
        {
            double totalCost = 0;
            foreach (Item item in Items)
                totalCost += item.Cost;
            LabelProductAmount.Text = $"{totalCost:n2}";
        }

        /// <summary>
        /// Вычисляет размер скидки
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ButtonCalculate</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double totalCost = 0;
            foreach (Item item in Items)
                totalCost += item.Cost;
            LabelDiscountAmount.Text = $"{(totalCost - percent.Calculate(Items)):n2}";
            UpdateInfo();
        }

        /// <summary>
        /// Применяет скидку
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ButtonApply</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ButtonApply_Click(object sender, EventArgs e)
        {
            double totalCost = 0;
            foreach (Item item in Items)
                totalCost += item.Cost;
            LabelDiscountAmount.Text = $"{totalCost - percent.Apply(Items):n2}";
            UpdateInfo();
        }

        /// <summary>
        /// Вычисляет проценты скидки
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ButtonUpdate</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            percent.Update(Items);
            UpdateInfo();
        }
    }
}
