using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class CollisionManager
    {
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double path = Math.Sqrt(
                Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) +
                Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));

            if ((ring1.RadiusMax + ring2.RadiusMax) <= path) return false;
            return
                !(ring1.RadiusMax + path < ring2.RadiusMin ||
                ring2.RadiusMax + path < ring1.RadiusMin);
        }

        public static bool IsCollision(MyRectangle rectangle1, MyRectangle rectangle2)
        {
            Point2D region = new Point2D(
                Math.Abs(rectangle2.Center.X - rectangle1.Center.X),
                Math.Abs(rectangle2.Center.Y - rectangle1.Center.Y));

            Point2D rect1Half = new Point2D(rectangle1.Width / 2, rectangle1.Height / 2);
            Point2D rect2Half = new Point2D(rectangle2.Width / 2, rectangle2.Height / 2);

            Point2D minRegion = rect1Half + rect2Half;

            return region.X < minRegion.X && region.Y < minRegion.Y;
        }
    }
}
