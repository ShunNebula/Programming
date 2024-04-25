using System;
using System.Drawing;

namespace Programming.Model
{
    public class MyRectangle
    {
        private double _length;
        private double _width;
        private Color _color = Color.Black;
        private Point2D _center;
        private static int _allRectanglesCount;
        private int _id;

        public double Height
        {
            get { return _length; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _length = value;
            }
        }

        public double Width
        { 
            get { return _width; } 
            set {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value; } 
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public Point2D Center
        {
            get { return _center; } 
            set { _center = value; }
        }

        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
            private set { _allRectanglesCount = value; }
        }

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public MyRectangle()
        {
            Id = _allRectanglesCount++;
        }

        public MyRectangle(double length, double width, Color color, Point2D center) : this() // вызов конструктора MyRectangle( [параметры this] )
        {
            Height = length;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}
