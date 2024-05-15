using Programming.Model;
using Programming.Resourses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        private static MyRectangle[] _rectangles = null;
        private static MyRectangle _currentRectangle = null;

        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = GetRandomRectangles(5);
            InitListBoxRectangles(5);
        }

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

        private void InitListBoxRectangles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ListBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }
        }

        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[ListBoxRectangles.SelectedIndex];

            TextBoxWidth.Text = _currentRectangle.Width.ToString();
            TextBoxLength.Text = _currentRectangle.Height.ToString();
            TextBoxColor.Text = _currentRectangle.Color.Name;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            TextBoxId.Text = _currentRectangle.Id.ToString();
        }

        private void TextBoxLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(TextBoxLength.Text);
                TextBoxLength.BackColor = AppColors.trueText;
            }
            catch (Exception)
            {
                TextBoxLength.BackColor = AppColors.falseText;
            }
        }

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

        private void ButtonFindRectangles_Click(object sender, EventArgs e)
        {
            ListBoxRectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
