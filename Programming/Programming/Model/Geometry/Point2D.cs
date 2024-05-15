using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о точке.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        private double _x;
        /// <summary>
        /// Координата Y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задаёт координату X. Должна быть положительной.
        /// </summary>
        public double X 
        {
            get { return _x; }
            private set {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value; } 
        }

        /// <summary>
        /// Возвращает и задаёт координату Y. Должна быть положительной.
        /// </summary>
        public double Y 
        {
            get { return _y; }
            private set {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value; } 
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительной.</param>
        /// <param name="y">Координата Y. Должна быть положительной.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Преобразует значения X и Y в строку.
        /// </summary>
        /// <returns>Возвращает строку "X = {X}; Y = {Y};"</returns>
        public override string ToString()
        {
            return $"X = {X}; Y = {Y};";
        }

        /// <summary>
        /// Возвращает новую точку, координаты которой равны сумме координат получаемых двух точек.
        /// </summary>
        /// <param name="point1">Первая точка.</param>
        /// <param name="point2">Вторая точка.</param>
        /// <returns>Возвращает новую точку</returns>
        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }

        /// <summary>
        /// Возвращает новую точку, координаты которой равны разнице координат получаемых двух точек.
        /// </summary>
        /// <param name="point1">Первая точка.</param>
        /// <param name="point2">Вторая точка.</param>
        /// <returns>Возвращает новую точку</returns>
        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
        }
    }
}
