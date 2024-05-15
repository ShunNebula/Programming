using System;
using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class MyRectangle
    {
        /// <summary>
        /// Высота прымоугольника.
        /// </summary>
        private double _height;
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;
        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private Color _color = Color.Black;
        /// <summary>
        /// Центр прямоугольника.
        /// </summary>
        private Point2D _center;
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        /// <summary>
        /// Уникальный идетификатор прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задаёт высоту прямоугольника. Должно быть положительным.
        /// </summary>
        public double Height
        {
            get { return _height; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должно быть положительным.
        /// </summary>
        public double Width
        { 
            get { return _width; } 
            set {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value; } 
        }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника.
        /// </summary>
        public Point2D Center
        {
            get { return _center; } 
            set { _center = value; }
        }

        /// <summary>
        /// Возвращает и задаёт количество прямоугольника.
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
            private set { _allRectanglesCount = value; }
        }

        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MyRectangle"/>.
        /// </summary>
        public MyRectangle()
        {
            Id = _allRectanglesCount++;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MyRectangle"/>.
        /// </summary>
        /// <param name="height">Высота прямоугольника. Должна быть положительной</param>
        /// <param name="width">Ширина прямоугольника. Должна быть положительной</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
        public MyRectangle(double height, double width, Color color, Point2D center) : this() // вызов конструктора MyRectangle( [параметры this] )
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}
