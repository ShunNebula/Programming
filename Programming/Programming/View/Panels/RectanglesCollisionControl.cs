﻿using Programming.Model;
using Programming.Resourses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private static List<MyRectangle> _rectangle = new List<MyRectangle>();
        private static MyRectangle _currentRectangle = null;
        private static List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void TextBoxXRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxXRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxXRectangle.Text);
                _currentRectangle.Center = new Point2D(text, _currentRectangle.Center.Y);
                TextBoxXRectangle.BackColor = AppColors.trueText;
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[ListBoxRectangles.SelectedIndex].Width / 2,
                    _rectanglePanels[ListBoxRectangles.SelectedIndex].Location.Y);

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxXRectangle.BackColor = AppColors.falseText;
            }
        }

        private void TextBoxYRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxYRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxYRectangle.Text);
                _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, int.Parse(TextBoxYRectangle.Text));
                TextBoxYRectangle.BackColor = AppColors.trueText;
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles.SelectedIndex].Location = new Point(
                    _rectanglePanels[ListBoxRectangles.SelectedIndex].Location.X,
                    text - _rectanglePanels[ListBoxRectangles.SelectedIndex].Height / 2);

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxYRectangle.BackColor = AppColors.falseText;
            }
        }

        private void TextBoxWidthRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxWidthRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxWidthRectangle.Text);
                _currentRectangle.Width = text;
                TextBoxWidthRectangle.BackColor = AppColors.trueText;
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles.SelectedIndex].Width = text;

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxWidthRectangle.BackColor = AppColors.falseText;
            }
        }

        private void TextBoxHeightRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxHeightRectangle.Text)) return;
            try
            {
                int text = int.Parse(TextBoxHeightRectangle.Text);
                _currentRectangle.Height = text;
                TextBoxHeightRectangle.BackColor = AppColors.trueText;
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxRectangles.SelectedIndex].Height = text;

                CheckCollision();
            }
            catch (Exception)
            {
                TextBoxHeightRectangle.BackColor = AppColors.falseText;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedIndex < 0) return;
            _rectangle.RemoveAt(ListBoxRectangles.SelectedIndex);
            _rectanglePanels.RemoveAt(ListBoxRectangles.SelectedIndex);
            PanelRectangle.Controls.RemoveAt(ListBoxRectangles.SelectedIndex);
            ListBoxRectangles.Items.RemoveAt(ListBoxRectangles.SelectedIndex);
            CheckCollision();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MyRectangle newRectangle = RectangleFactory.Randomize(1, PanelRectangle.Width, PanelRectangle.Height)[0];
            _rectangle.Add(newRectangle);

            ListBoxRectangles.Items.Add($"{newRectangle.Id}. ({newRectangle.Center} W = {newRectangle.Width}; H = {newRectangle.Height})");

            Panel newPanel = new Panel();
            newPanel.BackColor = AppColors.nonCollision;
            newPanel.Location = new Point((int)(newRectangle.Center.X - newRectangle.Width / 2), (int)(newRectangle.Center.Y - newRectangle.Height / 2));
            newPanel.Width = (int)newRectangle.Width;
            newPanel.Height = (int)newRectangle.Height;

            _rectanglePanels.Add(newPanel);
            PanelRectangle.Controls.Add(newPanel);
            CheckCollision();
        }

        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedIndex < 0)
            {
                TextBoxWidthRectangle.Text = string.Empty;
                TextBoxHeightRectangle.Text = string.Empty;
                TextBoxXRectangle.Text = string.Empty;
                TextBoxYRectangle.Text = string.Empty;
                TextBoxIDRectangle.Text = string.Empty;
            }

            else
            {
                _currentRectangle = _rectangle[ListBoxRectangles.SelectedIndex];

                TextBoxWidthRectangle.Text = _currentRectangle.Width.ToString();
                TextBoxHeightRectangle.Text = _currentRectangle.Height.ToString();
                TextBoxXRectangle.Text = _currentRectangle.Center.X.ToString();
                TextBoxYRectangle.Text = _currentRectangle.Center.Y.ToString();
                TextBoxIDRectangle.Text = _currentRectangle.Id.ToString();
            }
        }

        private void ChangeTextElemListBoxRectangle()
        {
            ListBoxRectangles.Items[ListBoxRectangles.SelectedIndex] = $"{_rectangle[ListBoxRectangles.SelectedIndex].Id}. (" +
                $"{_rectangle[ListBoxRectangles.SelectedIndex].Center} W = {_rectangle[ListBoxRectangles.SelectedIndex].Width}; " +
                $"H = {_rectangle[ListBoxRectangles.SelectedIndex].Height})";
        }

        private void CheckCollision()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.nonCollision;
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangle[i], _rectangle[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = AppColors.collision;
                    }
                }
            }
        }
    }
}
