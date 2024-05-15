using Programming.Model;
using Programming.Resourses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonControl : UserControl
    {
        public SeasonControl()
        {
            InitializeComponent();

            this.ComboBoxSeason.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
        }

        private void ButtonSeason_Click(object sender, EventArgs e)
        {
            switch (ComboBoxSeason.SelectedItem)
            {
                case Season.Spring:
                    GroupBoxSeason.BackColor = AppColors.springColor;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    GroupBoxSeason.BackColor = AppColors.autumnColor;
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }
    }
}
