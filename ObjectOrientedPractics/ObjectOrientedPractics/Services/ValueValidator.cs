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
    public class ValueValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength) throw new ArgumentNullException(propertyName + "должен быть меньше" + maxLength.ToString());
        }
        public static void AssertValueInRange(double num, double min, double max, string propertyName)
        {
            if (num < min ||  num > max) throw new ArgumentOutOfRangeException(propertyName + "должен быть от" + min.ToString() + " и до " + max.ToString());
        }
    }
}
