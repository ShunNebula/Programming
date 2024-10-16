using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о новом товаре(товарах)
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Массив с названиями товаров
        /// </summary>
        private static readonly string[] names;

        /// <summary>
        /// Массив с описаниями товаров
        /// </summary>
        private static readonly string[] infos;

        static ItemFactory()
        {
            names = File.ReadAllLines(@"C:\Users\User\source\repos\Programming\ObjectOrientedPractices\ObjectOrientedPractices\Services\ItemNames.txt");
            infos = File.ReadAllLines(@"C:\Users\User\source\repos\Programming\ObjectOrientedPractices\ObjectOrientedPractices\Services\ItemInfos.txt");
        }

        /// <summary>
        /// Возвращает список новых товаров
        /// </summary>
        /// <param name="size">Количество новых товаров</param>
        /// <returns>Список новых товаров</returns>
        public static List<Item> Randomize(int size)
        {
            List<Item> myItems = new List<Item>();
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                int categoryIndex = ran.Next(5);
                string[] name = names[categoryIndex].Split('|');
                string[] info = infos[categoryIndex].Split('|');

                Item newItem = new Item(
                    name[ran.Next(name.Length)].Trim(),
                    info[ran.Next(info.Length)].Trim(),
                    ran.NextDouble() * 10000 );
                
                myItems.Add(newItem);
            }

            return myItems;
        }
    }
}
