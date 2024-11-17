using System;
using System.Collections.Generic;
using System.IO;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о новом товаре(товарах)
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Путь до папки Texts
        /// </summary>
        private static string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Services\Texts");

        /// <summary>
        /// Список с названиями товаров
        /// </summary>
        private static readonly string[] _names = File.ReadAllLines($@"{_filePath}\ItemNames.txt");

        /// <summary>
        /// Список с описаниями товаров
        /// </summary>
        private static readonly string[] _infos = File.ReadAllLines($@"{_filePath}\ItemInfos.txt");

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
                int categoryIndex = ran.Next(Enum.GetValues(typeof(Category)).Length);
                string[] name = _names[categoryIndex].Split('|');
                string[] info = _infos[categoryIndex].Split('|');

                Item newItem = new Item(
                    name[ran.Next(name.Length)].Trim(),
                    info[ran.Next(info.Length)].Trim(),
                    ran.NextDouble() * 10000,
                    (Category)categoryIndex);
                
                myItems.Add(newItem);
            }

            return myItems;
        }
    }
}
