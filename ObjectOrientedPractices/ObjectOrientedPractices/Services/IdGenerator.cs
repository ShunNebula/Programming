namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Класс для создания уникального Id для покупателей и товаров.
    /// </summary>
    public class IdGenerator
    {
        private static int _counterOrder;

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
            else if (choice == "Customer")
                return ++_counterCustomer;
            else
                return ++_counterOrder;
        }

    }
}
