using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        private double _radiusMin;
        private double _radiusMax;
        private Point2D _center;

        public double RadiusMin
        {
            get { return _radiusMin; }
            set {
                Validator.AssertValueInRange(value, 0, _radiusMax, nameof(RadiusMin));
                _radiusMin = value; }
        }
        public double RadiusMax
        { 
            get { return _radiusMax; } 
            set {
                Validator.AssertValueInRange(value, _radiusMin, int.MaxValue, nameof(RadiusMax));
                _radiusMax = value; }
        }
        public Point2D Center
        { 
            get { return _center; } 
            set { _center = value; }
        }
        public double Area
        {
            get { return Square(_radiusMax) - Square(_radiusMin); }
        }

        private double Square(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }

        public Ring(int radiusMin, int radiusMax, Point2D center) 
        { 
            RadiusMin = radiusMin;
            RadiusMax = radiusMax;
            Center = center;
        }
    }
}
