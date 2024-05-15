using Programming.Model;
using Programming.Resourses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Класс для работы с прямоугольниками.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private static MyRectangle[] _rectangles = null;
        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private static MyRectangle _currentRectangle = null;

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = GetRandomRectangles(5);
            InitListBoxRectangles(5);
        }

        /// <summary>
        /// Создание списка, заполненного случайными прямоугольнками.
        /// </summary>
        /// <param name="size">Количество прямоугольников.</param>
        /// <returns>Возвращает список прямоугольников.</returns>
        private MyRectangle[] GetRandomRectangles(int size)
        {
            MyRectangle[] myRectangles = new MyRectangle[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                myRectangles[i] = new MyRectangle();
                myRectangles[i].Width = ran.Next(10, 200);
                myRectangles[i].Height = ran.Next(10, 200);
                myRectangles[i].Center = new Point2D(ran.Next(0, 450), ran.Next(0, 450));
            }

            return myRectangles;
        }

        /// <summary>
        /// Заполнение ListBoxRectangles перечислением прямоугольников.
        /// </summary>
        /// <param name="count">Количество прямоугольников.</param>
        private void InitListBoxRectangles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ListBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }
        }

        /// <summary>
        /// Заполенение TextBox высоты, ширины, цвета, X, Y и id.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ListBoxRectangles.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[ListBoxRectangles.SelectedIndex];

            TextBoxWidth.Text = _currentRectangle.Width.ToString();
            TextBoxHeight.Text = _currentRectangle.Height.ToString();
            TextBoxColor.Text = _currentRectangle.Color.Name;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            TextBoxId.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Проверка и изменение высоты.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxHeight.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void TextBoxHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(TextBoxHeight.Text);
                TextBoxHeight.BackColor = AppColors.trueText;
            }
            catch (Exception)
            {
                TextBoxHeight.BackColor = AppColors.falseText;
            }
        }

        /// <summary>
        /// Проверка и изменение ширины.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxWidth.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void TextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(TextBoxWidth.Text);
                TextBoxWidth.BackColor = AppColors.trueText;
            }
            catch (Exception)
            {
                TextBoxWidth.BackColor = AppColors.falseText;
            }
        }

        /// <summary>
        /// Проверка и изменение цвета.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - TextBoxColor.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void TextBoxColor_TextChanged(object sender, EventArgs e)
        {
            Color value = Color.FromName(TextBoxColor.Text);
            if (value.A == 0)
                TextBoxColor.BackColor = AppColors.falseText;
            else
            {
                _currentRectangle.Color = value;
                TextBoxColor.BackColor = AppColors.trueText;
            }
        }

        /// <summary>
        /// Нахождение индекса прямоугольника с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles">Список прямоугольников.</param>
        /// <returns>Индекс прямоугольника с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(MyRectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > rectangles[maxWidthIndex].Width)
                    maxWidthIndex = i;
            }
            return maxWidthIndex;
        }

        /// <summary>
        /// Поиск Прямоугольника с наибольшей шириной.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ButtonFindRectangles.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void ButtonFindRectangles_Click(object sender, EventArgs e)
        {
            ListBoxRectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
