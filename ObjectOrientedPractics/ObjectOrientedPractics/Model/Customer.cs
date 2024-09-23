using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 
        /// </summary>
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        private string _fullname;
        /// <summary>
        /// 
        /// </summary>
        private string _address;

        /// <summary>
        /// 
        /// </summary>
        public int Id 
        { 
            get; 
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fullname 
        { 
            get {  return _fullname; } 
            set 
            { 
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Address 
        { 
            get { return _address; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value; 
            }
        }

        public Customer()
        {
            Id = IdGenerator.GetNextId();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="address"></param>
        public Customer(string fullname, string address) : this()
        {
            Fullname = fullname;
            Address = address;
        }
    }
}
