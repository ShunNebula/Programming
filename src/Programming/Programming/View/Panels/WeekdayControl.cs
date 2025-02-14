using Programming.Model;
using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Класс для работы с днями недели.
    /// </summary>
    public partial class WeekdayControl : UserControl
    {
        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public WeekdayControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вывод в LabelParsing2 номер, введенного дня недели.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие - ButtonParse.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
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
