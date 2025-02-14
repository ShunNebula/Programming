using Programming.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Класс для работы с перечислением.
    /// </summary>
    public partial class EnumerationControl : UserControl
    {
        /// <summary>
        /// Перечисление типов.
        /// </summary>
        private static Type[] _enums = new Type[]
        {
            typeof(ColorList),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(Weekday),
        };

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public EnumerationControl()
        {
            InitializeComponent();

            this.EnumsListBox.Items.AddRange(_enums.Select(e => e.Name).ToArray());
            this.EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполнение EnumsListBox названиями типов.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Передает объект, относящийся к обрабатываемому событию.</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ValuesListBox.Items.Clear();
            Type selected = _enums[this.EnumsListBox.SelectedIndex];
            this.ValuesListBox.Items.AddRange(Enum.GetValues(selected).Cast<object>().ToArray());
        }

        /// <summary>
        /// Заполнение ValuesListBox перечислением из выбранного типа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EnumsTextBox.Text = ((int)this.ValuesListBox.SelectedItem).ToString();
        }
    }
}
