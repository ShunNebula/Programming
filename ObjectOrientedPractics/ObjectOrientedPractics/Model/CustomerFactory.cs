using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о новом случайном покупателе(покупателях)
    /// </summary>
    public class CustomerFactory
    {
        /// <summary>
        /// Возвращает список новых покупателей
        /// </summary>
        /// <param name="size">Количество новых покупателей</param>
        /// <returns>Список новых покупателей</returns>
        public static List<Customer> Randomize(int size)
        {
            var myCustomer = new List<Customer>();
            for (int i = 0; i < size; i++)
            {
                Customer newCustomer = new Customer();
                newCustomer.Fullname = "name";
            }
            return myCustomer;
        }
    }
}
