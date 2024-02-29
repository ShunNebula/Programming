using System;
using System.Drawing;

namespace Programming.Model
{
    public class MyRectangle
    {
        private double _length;
        private double _width;
        private Color _color = Color.Black;

        public double Length
        {
            get { return _length; }
            set 
            {
                if (value < 0) throw new ArgumentException();
                _length = value;
            }
        }

        public double Width
        { 
            get { return _width; } 
            set {
                if (value < 0) throw new ArgumentException();
                _width = value; } 
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public MyRectangle()
        {
            
        }

        public MyRectangle(double length, double width, Color color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}
