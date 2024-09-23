using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class IdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        private static int _counter;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetNextId()
        {
            return ++_counter;
        }

    }
}
