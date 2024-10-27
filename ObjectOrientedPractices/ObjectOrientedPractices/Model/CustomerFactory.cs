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
        private static string[] names = File.ReadAllLines($@"{Environment.CurrentDirectory}\Services\CustomerNames.txt");

        /// <summary>
        /// Представляет экземпляр генератора случайных чисел.
        /// </summary>
        private static Random _ran = new Random();

        /// <summary>
        /// Список стран
        /// </summary>
        private static List<string> countries = new List<string>
        {
            "Russia", "USA", "Canada", "United Kingdom", "France", "Germany", "Australia"
        };

        /// <summary>
        /// Список городов
        /// </summary>
        private static List<string> cities = new List<string>
        {
            "Moscow", "New York", "Toronto", "London", "Paris", "Berlin", "Sydney"
        };

        /// <summary>
        /// Список улиц
        /// </summary>
        private static List<string> streets = new List<string>
        {
            "Lenin", "Red", "Pushkin", "Pyatnitskaya", "October", "Sadowa"
        };
        /// <summary>
        /// Создаёт случайный адрес
        /// </summary>
        /// <returns>Новый адрес</returns>
        public static Address GenerateRandomAddress()
        {
            int index = _ran.Next(100000, 999999);
            string country = countries[_ran.Next(countries.Count)];
            string city = cities[_ran.Next(cities.Count)];
            string street = streets[_ran.Next(streets.Count)];
            string building = _ran.Next(1, 100).ToString();
            string apartment = _ran.Next(1, 50).ToString();


            return new Address(index, country, city, street, building, apartment);
        }

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
                    GenerateRandomAddress());

                myCustomer.Add(newCustomer);
            }
            return myCustomer;
        }
    }
}
