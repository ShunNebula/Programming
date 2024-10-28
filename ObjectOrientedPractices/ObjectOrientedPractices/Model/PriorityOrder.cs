using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Хранит данные о заказе приоритетного обслуживания
    /// </summary>
    public class PriorityOrder : Order
    {
        public DateTime DesiredDeliveryDate { get; set; }



    }
}
