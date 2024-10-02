using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о новом товаре(товарах)
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Массив с названиями товаров
        /// </summary>
        private static readonly string[][] names = new[]
        {
            new[] { "Laptop", "Smartphone", "Tablet", "Headphones", "Smartwatch" }, // Electronics
            new[] { "T-shirt", "Jeans", "Jacket", "Hat", "Shoes" },                // Clothing
            new[] { "Lipstick", "Foundation", "Mascara", "Perfume", "Eyeshadow" }, // Cosmetics
            new[] { "Chocolate", "Snacks", "Cereal", "Juice", "Fruits" },          // Food
            new[] { "Doll", "Action Figure", "Board Game", "Puzzle", "Toy Car" },  // Toys
            new[] { "Novel", "Textbook", "Magazine", "Comic Book", "Cookbook" },   // Books
            new[] { "Sofa", "Table", "Chair", "Bed", "Bookshelf" }                 // Furniture
        };
        /// <summary>
        /// Массив с описаниями товаров
        /// </summary>
        private static readonly string[][] infos = new[]
        {
        new[] { "High performance device.", "Compact and portable.", "Great for media consumption.", "Noise-cancelling feature.", "Track your fitness accurately." }, // Electronics
        new[] { "Comfortable and stylish.", "Durable and fashionable.", "Perfect for cold weather.", "Cool accessory.", "Trendy footwear." },                      // Clothing
        new[] { "Long-lasting color.", "Perfect for a natural look.", "Volume-boosting formula.", "Sweet floral scent.", "Vibrant eyeshadow palette." },           // Cosmetics
        new[] { "Rich and creamy.", "Perfect for a quick snack.", "A healthy breakfast choice.", "Refreshingly fruity.", "Naturally sweet." },                        // Food
        new[] { "Fun for all ages.", "Collectible figures.", "Great for family game night.", "Challenging and entertaining.", "Perfect for kids." },                // Toys
        new[] { "A captivating story.", "Essential knowledge for students.", "Latest news and trends.", "Exciting adventures in comic form.", "Delicious recipes." }, // Books
        new[] { "Stylish and comfortable.", "Space-saving design.", "Perfect for family gatherings.", "Elegant and functional.", "Great for organization." }         // Furniture
        };
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
                Item newItem = new Item();
                int categoryIndex = ran.Next(Enum.GetValues(typeof(Category)).Length);
                newItem.Category = (Category)categoryIndex;
                newItem.Name = names[categoryIndex][ran.Next(names[categoryIndex].Length)];
                newItem.Cost = ran.NextDouble() * 1000;
                newItem.Info = infos[categoryIndex][ran.Next(infos[categoryIndex].Length)];

                myItems.Add(newItem);
            }

            return myItems;
        }
    }
}
