using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Discounts;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Баллы
        /// </summary>
        private IDiscount _point = new PointsDiscount();

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
        /// Создаёт экземпляр класса <see cref="DiscountsTab"/>.
        /// </summary>
        public DiscountsTab()
        {
            InitializeComponent();
            UpdateLabel();
            UpdateInfo();
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
        /// Обновление LabelInfo
        /// </summary>
        private void UpdateInfo()
        {
            LabelInfo.Text = $"Info: {_point.Info}";
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
            LabelDiscountAmount.Text = $"{totalCost - _point.Calculate(Items):n2}";
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
            LabelDiscountAmount.Text = $"{totalCost - _point.Apply(Items):n2}";
            UpdateInfo();
        }

        /// <summary>
        /// Вычисляет баллы скидки
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ButtonUpdate</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            _point.Update(Items);
            UpdateInfo();
        }
    }
}
