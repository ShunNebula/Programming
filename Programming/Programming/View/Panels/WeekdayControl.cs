using Programming.Model;
using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class WeekdayControl : UserControl
    {
        public WeekdayControl()
        {
            InitializeComponent();
        }

        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<Weekday>(TextBoxParsing.Text, out Weekday result) && !int.TryParse(TextBoxParsing.Text, out int i))
            {
                LabelParsing2.Text = $"«Это день недели ({result} = {(int)result})»";
            }
            else
            {
                LabelParsing2.Text = "«Нет такого дня недели»";
            }
        }
    }
}
