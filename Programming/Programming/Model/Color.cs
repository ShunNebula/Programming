using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public partial class Color : Component
    {
        public Color()
        {
            InitializeComponent();
        }

        public Color(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public enum ColorEnum
        {
            Purple,
            Black,
            Gold,
            Red,
            Green,
            Blue,
            Yellow
        }
    }
}
