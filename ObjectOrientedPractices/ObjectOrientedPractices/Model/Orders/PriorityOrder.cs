using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе приоритетного обслуживания
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемое время доставки
        /// </summary>
        private string _desiredDeliveryTime;

        /// <summary>
        /// Регулярное выражение для проверки допустимых временных диапазонов
        /// </summary>
        private Regex _deliveryTimeRangeRegex = new Regex("^(09:00|11:00|13:00|15:00|17:00|19:00) - (11:00|13:00|15:00|17:00|19:00|21:00)$");

        /// <summary>
        /// Возвращает и задаёт желаемое время доставки
        /// </summary>
        public string DesiredDeliveryTime
        {
            get { return _desiredDeliveryTime; }
            set
            {
                try
                {
                    if (_deliveryTimeRangeRegex.IsMatch(value))
                    {
                        _desiredDeliveryTime = value;
                    }
                    else
                    {
                        throw new ArgumentException("Некорректный формат времени доставки. " +
                            "Используйте один из вариантов: \n" +
                            "09:00 - 11:00, \n" +
                            "11:00 - 13:00, \n" +
                            "13:00 - 15:00, \n" +
                            "15:00 - 17:00, \n" +
                            "17:00 - 19:00, \n" +
                            "19:00 - 21:00.");
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт желаемую дату доставки
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {
            
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки</param>
        /// <param name="items">Список товаров</param>
        /// <param name="amount">Общая цена товаров из списка</param>
        /// <param name="status">Статус заказа</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки</param>
        public PriorityOrder(Address address, List<Item> items, double amount, OrderStatus status, double discountAmount, DateTime desiredDeliveryDate, string desiredDeliveryTime)
            :base(address, items, amount, status, discountAmount)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}
