using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Малый радиус кольца.
        /// </summary>
        private double _radiusMin;
        /// <summary>
        /// Больший радиус кольца.
        /// </summary>
        private double _radiusMax;
        /// <summary>
        /// Центр кольца.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Возвращает и задает малый радиус кольца. Должен быть положительным и меньше большего радиуса.
        /// </summary>
        public double RadiusMin
        {
            get { return _radiusMin; }
            set {
                Validator.AssertValueInRange(value, 0, _radiusMax, nameof(RadiusMin));
                _radiusMin = value; }
        }

        /// <summary>
        /// Возвращает и задает больший радиус кольца. Должен быть больше малого радиуса.
        /// </summary>
        public double RadiusMax
        { 
            get { return _radiusMax; } 
            set {
                Validator.AssertValueInRange(value, _radiusMin, int.MaxValue, nameof(RadiusMax));
                _radiusMax = value; }
        }

        /// <summary>
        /// Возвращает и задает центр кольца.
        /// </summary>
        public Point2D Center
        { 
            get { return _center; } 
            set { _center = value; }
        }
        
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get { return Square(_radiusMax) - Square(_radiusMin); }
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <param name="rad">Радиус.</param>
        /// <returns>Возвращает значение площади.</returns>
        private double Square(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="radiusMin">Малый радиус кольца.</param>
        /// <param name="radiusMax">Больший радиус кольца.</param>
        /// <param name="center">Центр кольца.</param>
        public Ring(int radiusMin, int radiusMax, Point2D center) 
        { 
            RadiusMin = radiusMin;
            RadiusMax = radiusMax;
            Center = center;
        }
    }
}
