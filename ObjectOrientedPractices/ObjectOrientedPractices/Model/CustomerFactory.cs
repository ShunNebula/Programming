using System.Collections.Generic;
using System.IO;
using System;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о новом случайном покупателе(покупателях)
    /// </summary>
    public class CustomerFactory
    {
        /// <summary>
        /// Список имён
        /// </summary>
        private static string[] names = File.ReadAllLines(@"C:\Users\User\source\repos\Programming\ObjectOrientedPractices\ObjectOrientedPractices\Services\CustomerNames.txt");

        /// <summary>
        /// Возвращает список новых покупателей
        /// </summary>
        /// <param name="size">Количество новых покупателей</param>
        /// <returns>Список новых покупателей</returns>
        public static List<Customer> Randomize(int size)
        {
            Random ran = new Random();
            var myCustomer = new List<Customer>();

            for (int i = 0; i < size; i++)
            {
                Customer newCustomer = new Customer(
                    names[ran.Next(names.Length)], 
                    "address");

                myCustomer.Add(newCustomer);
            }
            return myCustomer;
        }
    }
}
