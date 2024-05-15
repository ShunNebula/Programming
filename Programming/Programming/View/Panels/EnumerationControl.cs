using Programming.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class EnumerationControl : UserControl
    {
        private static Type[] _enums = new Type[]
        {
            typeof(ColorList),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(Weekday),
        };

        public EnumerationControl()
        {
            InitializeComponent();

            this.EnumsListBox.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.EnumsListBox.SelectedIndex = 0;
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
    }
}
