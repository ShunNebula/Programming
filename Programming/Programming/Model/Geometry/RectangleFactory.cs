using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о новом случайном прямоугольнике.
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Возвращает новый прямоугольник.
        /// </summary>
        /// <param name="size">Размер прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="height">Высота прямоугольника.</param>
        /// <returns>Возвращает, созданный прямоугольник.</returns>
        public static MyRectangle[] Randomize(int size, int width, int height)
        {
            MyRectangle[] myRectangles = new MyRectangle[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                myRectangles[i] = new MyRectangle();
                myRectangles[i].Width = ran.Next(10, 200);
                myRectangles[i].Height = ran.Next(10, 200);
                myRectangles[i].Center = new Point2D(ran.Next(0, width), ran.Next(0, height));
            }

            return myRectangles;
        }
    }
}
