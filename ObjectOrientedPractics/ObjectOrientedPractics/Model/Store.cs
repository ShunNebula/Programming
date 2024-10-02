using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        List<Item> _items = new List<Item>();

        List<Customer> _customers = new List<Customer>();

        public List<Item> Items
        { 
            get { return _items; } 
            set { _items = value; } 
        }
        public List<Customer> Customers 
        { 
            get { return _customers; } 
            set { _customers = value; } 
        }
        public Store()
        {

        }
    }
}
