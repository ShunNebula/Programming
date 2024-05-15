using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int num, string property)
        {
            if (num < 0) throw new ArgumentException($"Value can't be negative: '{property}' = '{num}'.");
        }
        public static void AssertOnPositiveValue(double num, string property)
        {
            if (num < 0) throw new ArgumentException($"Value can't be negative: '{property}' = '{num}'.");
        }
        public static void AssertValueInRange(double num, double min, double max, string property)
        {
            if (num < min || num > max) throw new ArgumentException($"Value is out of range ({min}-{max}): '{property}' = '{num}'.");
        }
    }
}
