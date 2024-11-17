using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Класс для создания уникального Id для покупателей и товаров.
    /// </summary>
    public class IdGenerator
    {
        private static Dictionary<Type, int> _counter = new Dictionary<Type, int>();
        
        /// <summary>
        /// Возвращает уникальный Id
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <returns>Уникальный Id</returns>
        public static int GetNextId<T>()
        {
            if (!_counter.ContainsKey(typeof(T)))
            {
                _counter[typeof(T)] = 0;
            }

            return ++_counter[typeof(T)];
        }

    }
}
