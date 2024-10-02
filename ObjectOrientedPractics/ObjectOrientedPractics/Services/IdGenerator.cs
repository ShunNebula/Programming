using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Класс для создания уникального Id для покупателей и товаров.
    /// </summary>
    public class IdGenerator
    {
        /// <summary>
        /// Счётчик для Item
        /// </summary>
        private static int _counterItem;
        /// <summary>
        /// Счётчик для Customer
        /// </summary>
        private static int _counterCustomer;

        /// /// <summary>
        /// Возвращает уникальный Id
        /// </summary>
        /// <param name="choice">Строка с выбором (Item или Customer)</param>
        /// <returns>Уникальный Id</returns>
        public static int GetNextId(string choice)
        {
            if (choice == "Item")
                return ++_counterItem;
            else
                return ++_counterCustomer;
        }

    }
}
