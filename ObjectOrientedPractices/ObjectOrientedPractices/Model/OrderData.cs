using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    public class OrderData
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public string FullName { get; set; }
        public Address Address { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        public Order Order { get; set; }
    }
}
