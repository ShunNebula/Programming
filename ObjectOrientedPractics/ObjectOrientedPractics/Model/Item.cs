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
    public class Item
    {
        /// <summary>
        /// 
        /// </summary>
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        private string _name;
        /// <summary>
        /// 
        /// </summary>
        private string _info;
        /// <summary>
        /// 
        /// </summary>
        private double _cost;

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name 
        { 
            get { return _name; } 
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value; 
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Cost
        { 
            get { return _cost; } 
            set 
            { 
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value; 
            } 
        }

        public Item()
        {
            Id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="info"></param>
        /// <param name="cost"></param>
        public Item(string name, string info, double cost) : this()
        {
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
