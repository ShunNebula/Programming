using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private static Type[] _enums = new Type[]
        {
            typeof(ColorList),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(Weekday),
        };

        public MainForm()
        {
            InitializeComponent();

            this.EnumsListBox.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.EnumsListBox.SelectedIndex = 0;
            this.ComboBoxSeason.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ValuesListBox.Items.Clear();
            Type selected = _enums[this.EnumsListBox.SelectedIndex];
            this.ValuesListBox.Items.AddRange(Enum.GetValues(selected).Cast<object>().ToArray());
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EnumsTextBox.Text = ((int)this.ValuesListBox.SelectedItem).ToString();
        }

        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<Weekday>(TextBoxParsing.Text, out Weekday result))
            {
                LabelParsing2.Text = $"«Это день недели ({result} = {(int)result})»";
            }
            else
            {
                LabelParsing2.Text = "«Нет такого дня недели»";
            }
        }



        private void ButtonSeason_Click(object sender, EventArgs e)
        {
            switch (ComboBoxSeason.SelectedItem)
            {
                case Season.Spring:
                    GroupBoxSeason.BackColor = Color.FromArgb(48, 213, 200);
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    GroupBoxSeason.BackColor = Color.FromArgb(255, 166, 97);
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }
    }
}
